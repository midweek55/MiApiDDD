namespace MiApiDDD.Dominio.Entidades
{
    public class AccionModulo
    {
        public Guid Id { get; set; }
        // Suponiendo que IDMODULO es una referencia a otra entidad Modulo
        public Guid ModuloId { get; set; }
        public Modulo Modulo { get; set; }
        public string Nombre { get; set; }
        // Otras propiedades relevantes
    }
}