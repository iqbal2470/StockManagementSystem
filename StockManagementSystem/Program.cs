using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockManagementSystem.Data;
using StockManagementSystem.Forms.Brands;
using StockManagementSystem.Forms.Categories;
using StockManagementSystem.Forms.Dashboard;
using StockManagementSystem.Forms.Login;
using StockManagementSystem.Forms.Units;

//using StockManagementSystem.Forms.Authentication;
using StockManagementSystem.Interfaces;
//using StockManagementSystem.Forms.Authentication;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Repositories;
using StockManagementSystem.Repositories;
using StockManagementSystem.Services.BrandServices;
using StockManagementSystem.Services.CategoryServices;
using StockManagementSystem.Services.CategoryServices;
using StockManagementSystem.Services.UnitServices;
using StockManagementSystem.Services.UserServices;
namespace StockManagementSystem
{
    internal static class Program
    {
        private static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(
                            context.Configuration.GetConnectionString("Conn")));
                    services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

                    services.AddScoped<ICategoryRepository, CategoryRepository>();

                    services.AddScoped<ICategoryService, CategoryService>();

                    services.AddScoped<IUserService, UserService>();

                    services.AddScoped<IUserRepository, UserRepository>();

                    services.AddScoped<IBrandRepository, BrandRepository>();

                    services.AddScoped<IBrandService, BrandService>();


                    services.AddScoped<IUnitRepository, UnitRepository>();
                    services.AddScoped<IUnitService, UnitService>();

                    services.AddTransient<FrmUnit>();
                    services.AddTransient<FrmLogin>();
                    services.AddTransient<FrmCategory>();
                    services.AddTransient<FrmCreateAdmin>();
                    services.AddTransient<FrmDashboard>();
                    services.AddTransient<FrmBrand>();
                })
                .Build();
        }
        public static IServiceProvider Services { get; private set; } = null!;
        //[STAThread]
        //static void Main()
        //{
        //    ApplicationConfiguration.Initialize();

        //    var host = CreateHostBuilder();
        //    Services = host.Services;
        //    Application.Run(Services.GetRequiredService<FrmCategory>());
        //}

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder();

            Services = host.Services;

            using (var scope = Services.CreateScope())
            {
                var userService = scope.ServiceProvider.GetRequiredService<IUserService>();

                bool userExists = userService.AnyUserExistsAsync()
                                             .GetAwaiter()
                                             .GetResult();

                if (!userExists)
                {
                    var createAdmin = scope.ServiceProvider
                                           .GetRequiredService<FrmCreateAdmin>();

                    if (createAdmin.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

                var login = scope.ServiceProvider.GetRequiredService<FrmLogin>();

                if (login.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Application.Run(scope.ServiceProvider.GetRequiredService<FrmDashboard>());
            }
        }
    }
}