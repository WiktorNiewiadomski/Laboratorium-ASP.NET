using Laboratorium_3.Models;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Data;

namespace Laboratorium_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddTransient<IComputerService, EFComputerService>();
            builder.Services.AddTransient<IProcessorService, EFProcessorService>();
            builder.Services.AddTransient<IStorageService, EFStorageService>();
            builder.Services.AddTransient<IGraphicsCardService, EFGraphicsCardService>();
            builder.Services.AddMemoryCache();
            builder.Services.AddSession();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}