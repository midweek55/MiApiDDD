namespace MiApiDDD.Dominio.Entidades;

public class RolUsuario
{
    public Guid UsuarioId { get; private set; }
    public Usuario Usuario { get; private set; }

    public Guid RolId { get; private set; }
    public Rol Rol { get; private set; }

    // Constructor privado para EF Core
    private RolUsuario() { }

    // Constructor público para crear instancias
    public RolUsuario(Guid usuarioId, Guid rolId)
    {
        UsuarioId = usuarioId;
        RolId = rolId;
    }
}