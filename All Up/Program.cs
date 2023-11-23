using All_Up.DAL;
using Microsoft.EntityFrameworkCore;

namespace All_Up
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-LUGHNBO;Database=AllDB;Trusted_Connection=True");
            });
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseStaticFiles();
            app.MapControllerRoute
                (
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            app.MapControllerRoute
                (
                    name: "default",
                    pattern: "{controller=All}/{action=Index}"
                );
            app.Run();
        }
    }
}