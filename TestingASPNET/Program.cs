using TestingASPNET.Controllers;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }
        app.UseDeveloperExceptionPage();
        app.UseStatusCodePages();
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Sorting}/{action=Index}/{id?}");
            /*endpoints.MapControllerRoute(
                name: "customRoute",
                pattern: "Controllers/{category}/{action}",
                defaults: new { controller = "SortingController", action = "Index" });*/
        });

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}