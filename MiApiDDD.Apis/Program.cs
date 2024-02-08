using MediatR;
using MiApiDDD.Aplicacion.Contratos;
using MiApiDDD.Aplicacion.Services;
using MiApiDDD.Infraestructura;
using MiApiDDD.Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Asegúrate de registrar el contexto de la base de datos si aún no lo has hecho
builder.Services.AddDbContext<MiContextoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registra IUsuarioRepository y su implementación concreta
builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

// Registra UsuarioService
builder.Services.AddScoped<UsuarioService>();

var app = builder.Build();

// Configura el middleware y las rutas aquí
app.MapControllers();

app.Run();