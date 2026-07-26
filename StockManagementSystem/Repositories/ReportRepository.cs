using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Reports;
using StockManagementSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;

        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PurchaseReportModel>> GetPurchaseReportAsync(DateTime fromDate, DateTime toDate)
        {
            return await _context.Purchases
                .Include(x => x.Product)
                    .ThenInclude(x => x.Category)
                .Include(x => x.Product)
                    .ThenInclude(x => x.Brand)
                .Where(x => x.PurchaseDate.Date >= fromDate.Date &&
                            x.PurchaseDate.Date <= toDate.Date)
                .Select(x => new PurchaseReportModel
                {
                    PurchaseNo = x.PurchaseNo,
                    PurchaseDate = x.PurchaseDate,
                    ProductCode = x.Product.ProductCode,
                    ProductName = x.Product.ProductName,
                    Category = x.Product.Category.CategoryName,
                    Brand = x.Product.Brand.BrandName,
                    PurchasePrice = x.PurchasePrice,
                    Quantity = x.Quantity,
                    TotalAmount = x.TotalAmount
                })
                .ToListAsync();
        }
        public async Task<List<SalesReportModel>> GetSalesReportAsync(DateTime fromDate, DateTime toDate)
        {
            return await _context.Sales
                .Include(x => x.Product)
                    .ThenInclude(x => x.Category)
                .Include(x => x.Product)
                    .ThenInclude(x => x.Brand)
                .Where(x => x.SaleDate.Date >= fromDate.Date &&
                            x.SaleDate.Date <= toDate.Date)
                .Select(x => new SalesReportModel
                {
                    SaleNo = x.SaleNo,
                    SaleDate = x.SaleDate,
                    ProductCode = x.Product.ProductCode,
                    ProductName = x.Product.ProductName,
                    Category = x.Product.Category.CategoryName,
                    Brand = x.Product.Brand.BrandName,
                    SalePrice = x.SalePrice,
                    Quantity = x.Quantity,
                    TotalAmount = x.TotalAmount
                })
                .ToListAsync();
        }
        public async Task<List<StockReportModel>> GetStockReportAsync()
        {
            return await _context.Products
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.Unit)
                .Select(x => new StockReportModel
                {
                    ProductCode = x.ProductCode,
                    ProductName = x.ProductName,
                    Category = x.Category.CategoryName,
                    Brand = x.Brand.BrandName,
                    Unit = x.Unit.UnitName,
                    PurchasePrice = x.PurchasePrice,
                    SalePrice = x.SalePrice,
                    CurrentStock = x.CurrentStock,
                    MinimumStock = x.MinimumStock,
                    IsActive = x.IsActive
                })
                .ToListAsync();



        }

                        public async Task<ReportSummaryModel> GetReportSummaryAsync(
                            string reportType,
                            DateTime fromDate,
                            DateTime toDate)
                        {
                            ReportSummaryModel summary = new ReportSummaryModel();

                            switch (reportType)
                            {
                                case "Purchase Report":

                                    var purchases = await _context.Purchases
                                        .Where(x => x.PurchaseDate.Date >= fromDate.Date &&
                                                    x.PurchaseDate.Date <= toDate.Date)
                                        .ToListAsync();

                                    //summary.TotalProducts = purchases.Sum(x => x.Quantity);
                                    summary.TotalProducts = purchases
                    .Select(x => x.ProductId)
                    .Distinct()
                    .Count();

                                    summary.TotalPurchase = purchases.Sum(x => x.TotalAmount);

                                    summary.TotalSales = 0;

                                    summary.Profit = 0;

                                    break;

                                case "Sales Report":

                                    var sales = await _context.Sales
                                        .Include(x => x.Product)
                                        .Where(x => x.SaleDate.Date >= fromDate.Date &&
                                                    x.SaleDate.Date <= toDate.Date)
                                        .ToListAsync();

                                    //summary.TotalProducts = sales.Sum(x => x.Quantity);
                                    summary.TotalProducts = sales
                    .Select(x => x.ProductId)
                    .Distinct()
                    .Count();

                                    summary.TotalSales = sales.Sum(x => x.TotalAmount);

                                    summary.TotalPurchase =
                                        sales.Sum(x => x.Product.PurchasePrice * x.Quantity);

                                    summary.Profit =
                                        summary.TotalSales - summary.TotalPurchase;

                                    break;

                                case "Stock Report":

                                    var products = await _context.Products.ToListAsync();

                                    summary.TotalProducts = products.Count;

                                    summary.TotalPurchase =
                                        products.Sum(x => x.PurchasePrice * x.CurrentStock);

                                    summary.TotalSales =
                                        products.Sum(x => x.SalePrice * x.CurrentStock);

                                    summary.Profit =
                                        summary.TotalSales - summary.TotalPurchase;

                                    break;
                            }

                            return summary;
                        }


        public async Task<List<ChartDataModel>> GetCartesianChartDataAsync(
    string reportType,
    DateTime fromDate,
    DateTime toDate)
        {
            switch (reportType)
            {
                case "Purchase Report":
                    return await GetPurchaseChartDataAsync(fromDate, toDate);

                case "Sales Report":
                    return await GetSalesChartDataAsync(fromDate, toDate);

                //case "Stock Report":
                //    return await GetStockChartDataAsync();

                case "Stock Report":
                    return await GetStockChartDataAsync(fromDate, toDate);
                default:
                    return new List<ChartDataModel>();
            }
        }

        private async Task<List<ChartDataModel>> GetPurchaseChartDataAsync(
    DateTime fromDate,
    DateTime toDate)
        {
            return await _context.Purchases
                .Where(x => x.PurchaseDate >= fromDate &&
                            x.PurchaseDate <= toDate)
                .GroupBy(x => x.PurchaseDate.Date)
                .OrderBy(x => x.Key)
                .Select(x => new ChartDataModel
                {
                    Label = x.Key.ToString("dd MMM"),
                    Value = x.Sum(y => y.TotalAmount)
                })
                .ToListAsync();
        }
        //    private async Task<List<ChartDataModel>> GetSalesChartDataAsync(
        //DateTime fromDate,
        //DateTime toDate)
        //    {
        //        return await _context.Sales
        //            .Include(x => x.Product)
        //            .Where(x => x.SaleDate.Date >= fromDate.Date &&
        //                        x.SaleDate.Date <= toDate.Date)
        //            .GroupBy(x => x.SaleDate.Date)
        //            .OrderBy(x => x.Key)
        //            .Select(g => new ChartDataModel
        //            {
        //                Label = g.Key.ToString("dd MMM"),

        //                Value = g.Sum(x => x.TotalAmount),

        //                SecondValue = g.Sum(x =>
        //                    x.TotalAmount -
        //                    (x.Product.PurchasePrice * x.Quantity))
        //            })
        //            .ToListAsync();
        //    }

        private async Task<List<ChartDataModel>> GetSalesChartDataAsync(
    DateTime fromDate,
    DateTime toDate)
        {
            return  _context.Sales
                .Include(x => x.Product)
                .Where(x => x.SaleDate.Date >= fromDate.Date &&
                            x.SaleDate.Date <= toDate.Date)
                .AsEnumerable() // <-- IMPORTANT
                .GroupBy(x => x.SaleDate.Date)
                .OrderBy(x => x.Key)
                .Select(g => new ChartDataModel
                {
                    Label = g.Key.ToString("dd MMM"),

                    Value = g.Sum(x => x.TotalAmount),

                    Profit = g.Sum(x =>
                    {
                        decimal p = x.TotalAmount - (x.Product.PurchasePrice * x.Quantity);
                        return p > 0 ? p : 0;
                    }),

                    Loss = g.Sum(x =>
                    {
                        decimal l = x.TotalAmount - (x.Product.PurchasePrice * x.Quantity);
                        return l < 0 ? Math.Abs(l) : 0;
                    })
                })
                .ToList();
        }


        //    private async Task<List<ChartDataModel>> GetSalesChartDataAsync(
        //DateTime fromDate,
        //DateTime toDate)
        //    {
        //        return await _context.Sales
        //            .Where(x => x.SaleDate >= fromDate &&
        //                        x.SaleDate <= toDate)
        //            .GroupBy(x => x.SaleDate.Date)
        //            .OrderBy(x => x.Key)
        //            .Select(x => new ChartDataModel
        //            {
        //                Label = x.Key.ToString("dd MMM"),
        //                Value = x.Sum(y => y.TotalAmount)
        //            })
        //            .ToListAsync();
        //    }
        private async Task<List<ChartDataModel>> GetStockChartDataAsync(
        DateTime fromDate,
        DateTime toDate)
        {
            return await _context.Sales
                .Include(x => x.Product)
                .Where(x => x.SaleDate.Date >= fromDate.Date &&
                            x.SaleDate.Date <= toDate.Date)
                .GroupBy(x => new
                {
                    x.ProductId,
                    x.Product.ProductName
                })
                .Select(g => new ChartDataModel
                {
                    Label = g.Key.ProductName,
                    Value = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.Value)
                .Take(10)
                .ToListAsync();
        }
        //private async Task<List<ChartDataModel>> GetStockChartDataAsync()
        //{
        //    return await _context.Products
        //        .OrderBy(x => x.ProductName)
        //        .Select(x => new ChartDataModel
        //        {
        //            Label = x.ProductName,
        //            Value = x.CurrentStock
        //        })
        //        .ToListAsync();
        //}






        public async Task<List<PieChartDataModel>> GetPieChartDataAsync(
    string reportType,
    DateTime fromDate,
    DateTime toDate)
        {
            switch (reportType)
            {
                case "Purchase Report":
                    return await GetPurchasePieChartDataAsync(fromDate, toDate);

                case "Sales Report":
                    return await GetSalesPieChartDataAsync(fromDate, toDate);

                case "Stock Report":
                    return await GetStockPieChartDataAsync();

                default:
                    return new List<PieChartDataModel>();
            }
        }

        private async Task<List<PieChartDataModel>> GetPurchasePieChartDataAsync(
     DateTime fromDate,
     DateTime toDate)
        {
            return await _context.Purchases
                .Include(x => x.Product)
                .ThenInclude(x => x.Category)
                .Where(x => x.PurchaseDate.Date >= fromDate.Date &&
                            x.PurchaseDate.Date <= toDate.Date)
                .GroupBy(x => x.Product.Category.CategoryName)
                .Select(x => new PieChartDataModel
                {
                    Label = x.Key,
                    Value = x.Sum(y => y.Quantity)
                })
                .OrderByDescending(x => x.Value)
                .ToListAsync();
        }

        private async Task<List<PieChartDataModel>> GetSalesPieChartDataAsync(
     DateTime fromDate,
     DateTime toDate)
        {
            return await _context.Sales
                .Include(x => x.Product)
                .ThenInclude(x => x.Category)
                .Where(x => x.SaleDate.Date >= fromDate.Date &&
                            x.SaleDate.Date <= toDate.Date)
                .GroupBy(x => x.Product.Category.CategoryName)
                .Select(x => new PieChartDataModel
                {
                    Label = x.Key,
                    Value = x.Sum(y => y.Quantity)
                })
                .OrderByDescending(x => x.Value)
                .ToListAsync();
        }

        private async Task<List<PieChartDataModel>> GetStockPieChartDataAsync()
        {
            return await _context.Products
                .GroupBy(x =>
                    x.CurrentStock <= 0
                        ? "Out of Stock"
                        : x.CurrentStock < x.MinimumStock
                            ? "Low Stock"
                            : "In Stock")
                .Select(x => new PieChartDataModel
                {
                    Label = x.Key,
                    Value = x.Count()
                })
                .ToListAsync();
        }

    }
}
