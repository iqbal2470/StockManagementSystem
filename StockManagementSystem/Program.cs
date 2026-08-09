using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuestPDF.Infrastructure;
using StockManagementSystem.Data;
using StockManagementSystem.Forms.BackupRestore;
using StockManagementSystem.Forms.Brands;
using StockManagementSystem.Forms.Categories;
using StockManagementSystem.Forms.Dashboard;
using StockManagementSystem.Forms.History;
using StockManagementSystem.Forms.LicenseActivation;
using StockManagementSystem.Forms.Login;
using StockManagementSystem.Forms.Products;
using StockManagementSystem.Forms.Purchase;
using StockManagementSystem.Forms.Reports;
using StockManagementSystem.Forms.Sales;
using StockManagementSystem.Forms.Stock;
using StockManagementSystem.Forms.Units;
//using StockManagementSystem.Forms.Authentication;
using StockManagementSystem.Interfaces;
//using StockManagementSystem.Forms.Authentication;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Repositories;
using StockManagementSystem.Repositories;

//using StockManagementSystem.Services;

//using StockManagementSystem.Services;
using StockManagementSystem.Services.BackupServices;
using StockManagementSystem.Services.BrandServices;
using StockManagementSystem.Services.CategoryServices;
using StockManagementSystem.Services.CategoryServices;
using StockManagementSystem.Services.Dashboard;
using StockManagementSystem.Services.ProductServices;
using StockManagementSystem.Services.PurchaseService;
using StockManagementSystem.Services.ReportService;
using StockManagementSystem.Services.ReportsService;
using StockManagementSystem.Services.SaleService;
using StockManagementSystem.Services.StockServices;
using StockManagementSystem.Services.StockTransactionServices;
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

                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IProductService, ProductService>();

                    services.AddScoped<IPurchaseRepository, PurchaseRepository>();
                    services.AddScoped<IPurchaseService, PurchaseService>();

                    services.AddScoped<ISaleRepository, SaleRepository>();
                    services.AddScoped<ISaleService, SaleService>();

                    services.AddScoped<IStockService, StockService>();

                    services.AddScoped<IReportRepository, ReportRepository>();
                    services.AddScoped<IReportService, ReportService>();

                    services.AddScoped<IDashboardRepository, DashboardRepository>();
                    services.AddScoped<IDashboardService, DashboardService>();


                    services.AddScoped<IStockTransactionRepository, StockTransactionRepository>();
                    services.AddScoped<IStockTransactionService, StockTransactionService>();

                    services.AddScoped<IBackupService, BackupService>();

                    services.AddScoped<ISalePurchaseDetailRepository, SalePurchaseDetailRepository>();


                    services.AddTransient<FrmBackupRestore>();
                    services.AddTransient<FrmHistory>();
                    services.AddTransient<RrmReports>();
                    services.AddTransient<FrmStock>();
                    services.AddTransient<FrmSale>();
                    services.AddTransient<FrmPurchase>();
                    services.AddTransient<FrmProduct>();
                    services.AddTransient<FrmUnit>();
                    services.AddTransient<FrmLogin>();
                    services.AddTransient<FrmCategory>();
                    services.AddTransient<FrmCreateAdmin>();
                    services.AddTransient<FrmDashboard>();
                    services.AddTransient<FrmBrand>();
                    services.AddTransient<FrmLicenseActivation>();
                    services.AddTransient<FrmLicenseInfo>();
                    services.AddTransient<FrmLicenseRenewal>();
                    services.AddTransient<FrmProductNew>();
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
            QuestPDF.Settings.License = LicenseType.Community;
            var host = CreateHostBuilder();

            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                db.Database.Migrate();
            }

            Services = host.Services;


            using (var scope = Services.CreateScope())
            {

                // License Check
                if (!StockManagementSystem.Services.LicenseService.IsLicenseValid())
                {
                    var activation = scope.ServiceProvider
                                          .GetRequiredService<FrmLicenseActivation>();

                    if (activation.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

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
                //var login = scope.ServiceProvider.GetRequiredService<FrmLicenseActivation>();

                if (login.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                if (!StockManagementSystem.Services.LicenseService.IsLifetimeLicense())
                {
                    int remainingDays = StockManagementSystem.Services.LicenseService.GetRemainingDays();

                    if (remainingDays >= 0 &&
                        remainingDays <= 7 &&
                        StockManagementSystem.Services.LicenseWarningService.ShouldShowWarning())
                    {
                        MessageBox.Show(
                            $"Your license will expire in {remainingDays} day(s).\n\n" +
                            "Please contact Team Arrive to renew your license.",
                            "License Expiry Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        StockManagementSystem.Services.LicenseWarningService.SaveWarningDate();
                    }
                }

                Application.Run(scope.ServiceProvider.GetRequiredService<FrmDashboard>());
            }
        }
    }
}