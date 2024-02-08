namespace MiApiDDD.Dominio.Entidades
{
    public class PermisoRol
    {
        public Guid Id { get; set; }
        public Guid RolId { get; set; }
        public Rol Rol { get; set; }
        public Guid AccionModuloId { get; set; }
        public AccionModulo AccionModulo { get; set; }
        public Guid ModuloId { get; set; }
        public Modulo Modulo { get; set; } 
        // Otras propiedades y relaciones
    }
}