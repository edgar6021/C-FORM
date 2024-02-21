// Startup.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaVentas.Models;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();

        // Configuración de otros servicios
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        // Agregar servicios de autenticación y autorización si es necesario
        // services.AddAuthentication();
        // services.AddAuthorization();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // Agregar middleware de autenticación y autorización si es necesario
        // app.UseAuthentication();
        // app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Configurar rutas para otras páginas
            endpoints.MapControllerRoute(
                name: "usuarios",
                pattern: "{controller=Usuario}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "ventas",
                pattern: "{controller=Ventas}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "productos",
                pattern: "{controller=Productos}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "detallesVentas",
                pattern: "{controller=DetallesVentas}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "historiaVentas",
                pattern: "{controller=HistoriaVentas}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "perfilUsuario",
                pattern: "{controller=PerfilUsuario}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "login",
                pattern: "{controller=Account}/{action=Login}/{id?}");
        });
    }
}
