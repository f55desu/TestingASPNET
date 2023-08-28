using Microsoft.AspNetCore.Mvc.Routing;
using TestingASPNET.Configuration;
using TestingASPNET.Controllers;
using TestingASPNET.Services.SendingDataService;

internal class Program
{
    private static void BootstrapServices(IServiceCollection services)
    {
        services.AddTransient<ISendingDataService, SendingDataServiceClass>();
    }

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;
        
        services.AddRazorPages();
        services.AddControllers();
        services.AddAppAutoMappers();
        
        BootstrapServices(services);

        
        services.Configure<RouteOptions>(options =>
        {
            options.ConstraintMap.Add("apiVersion", typeof(ApiVersionRouteConstraint));
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error")
                ;
            app.UseHsts();
        }
        app.UseDeveloperExceptionPage();
        app.UseStatusCodePages();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                name: "Sorting",
                pattern: "{controller=Sorting}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                name: "DisplayResult",
                pattern: "{controller=DisplayResult}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                name: "Test",
                pattern: "{controller=Test}/{action=Index}/{id?}");
        });

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}