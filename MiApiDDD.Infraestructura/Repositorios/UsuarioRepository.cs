using MiApiDDD.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MiApiDDD.Infraestructura.Repositorios;

public class UsuarioRepository : IUsuarioRepository, Aplicacion.Contratos.IUsuarioRepository
{
    private readonly MiContextoDbContext _context;

    public UsuarioRepository(MiContextoDbContext context)
    {
        _context = context;
    }

    public async Task<List<string>> ObtenerNombresModulosPorUsuarioIdAsync(Guid usuarioId)
    {
        var nombresModulos = await _context.RolUsuarios
            .Where(ru => ru.UsuarioId == usuarioId)
            .SelectMany(ru => ru.Rol.PermisoRol)
            .Select(pr => pr.Modulo.Nombre) // Asumiendo que PermisoRol tiene una propiedad Modulo
            .Distinct()
            .ToListAsync();

        return nombresModulos;
    }
}