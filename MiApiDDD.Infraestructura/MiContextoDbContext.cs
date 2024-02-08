using MiApiDDD.Dominio.Entidades;
using MiApiDDD.Infraestructura.Configuracion;
using Microsoft.EntityFrameworkCore;

namespace MiApiDDD.Infraestructura
{
    public class MiContextoDbContext : DbContext
    {
        public MiContextoDbContext(DbContextOptions<MiContextoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        // Otros DbSets...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolUsuario>()
                .HasKey(ru => new { ru.UsuarioId, ru.RolId });

            modelBuilder.Entity<RolUsuario>()
                .HasOne(ru => ru.Usuario)
                .WithMany(u => u.RolUsuarios)
                .HasForeignKey(ru => ru.UsuarioId);

            modelBuilder.Entity<RolUsuario>()
                .HasOne(ru => ru.Rol)
                .WithMany(r => r.RolUsuarios)
                .HasForeignKey(ru => ru.RolId);
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
            // Aplicar otras configuraciones...
        }
    }
}