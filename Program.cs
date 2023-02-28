using LibraryAngular.Backend.BLL;
using LibraryAngular.Backend.DLL;

namespace LibraryAngular
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddSingleton<LibraryRepository>();

            builder.Services.AddScoped(s => new LibraryService(s.GetRequiredService<LibraryRepository>()));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}