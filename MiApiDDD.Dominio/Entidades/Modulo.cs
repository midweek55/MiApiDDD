namespace MiApiDDD.Dominio.Entidades
{
    public class Modulo
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        // Otros campos relevantes

        // Constructor privado para EF Core
        private Modulo() { }

        // Constructor público para crear instancias
        public Modulo(string nombre, string descripcion)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
        }

        // Métodos de dominio aquí
    }
}