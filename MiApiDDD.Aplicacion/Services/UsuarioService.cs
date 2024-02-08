using MiApiDDD.Dominio.Interfaces;

namespace MiApiDDD.Aplicacion.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // Método para obtener los nombres de los módulos a los que un usuario tiene acceso
        public async Task<List<string>> ObtenerNombresModulosPorUsuarioId(Guid usuarioId)
        {
            // Utiliza el repositorio para obtener la información requerida
            var nombresModulos = await _usuarioRepository.ObtenerNombresModulosPorUsuarioIdAsync(usuarioId);

            // Aquí puedes agregar cualquier lógica adicional necesaria antes de devolver los nombres de los módulos
            // Por ejemplo, filtrar, ordenar o transformar los datos según sea necesario

            return nombresModulos;
        }
    }
}