namespace MiApiDDD.Dominio.Entidades
{
    public class Rol
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public ICollection<RolUsuario> RolUsuarios { get; set; }
        public virtual ICollection<PermisoRol> PermisoRol { get; set; } = new List<PermisoRol>();
        
        public Rol(string nombre)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
        }
        
    }
}