using DAO;
using DAO.Interfaces;
using Services;
using Services.Interfaces;

namespace API.Settings.DI;

public static class DependencyInjection
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        builder.Services.AddScoped<IUsuarioService, UsuarioService>();
    }
}