using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Dashboard;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StockManagementSystem.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly ApplicationDbContext _context;

        public DashboardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DashboardSummaryModel> GetDashboardSummaryAsync()
        {
            return new DashboardSummaryModel
            {
                TotalProducts = await _context.Products.CountAsync(x => x.IsActive),

                TotalCategories = await _context.Categories.CountAsync(),

                TotalBrands = await _context.Brands.CountAsync(),

                TotalUnits = await _context.Units.CountAsync(),

                TotalPurchaseAmount =
                    await _context.Purchases.SumAsync(x => (decimal?)x.TotalAmount) ?? 0,

                TotalSalesAmount =
                    await _context.Sales.SumAsync(x => (decimal?)x.TotalAmount) ?? 0,

                CurrentStock =
                    await _context.Products.Where(x => x.IsActive).SumAsync(x => (int?)x.CurrentStock) ?? 0,

                //LowStockProducts =
                //    await _context.Products.CountAsync(x => x.CurrentStock <= x.MinimumStock)
                LowStockProducts =
    await _context.Products.CountAsync(x =>
    x.IsActive &&
        x.CurrentStock > 0 &&
        x.CurrentStock < x.MinimumStock)
            };
        }
        //public async Task<List<SalesChartModel>> GetSalesChartAsync(string dt)
        //{
        //    dt = dt?.Trim() ?? "This Month";

        //    switch (dt)
        //    {
        //        case "Today":
        //            {
        //                var today = DateTime.Today;

        //                return await _context.Sales
        //                    .Where(x => x.SaleDate.Date == today)
        //                    .GroupBy(x => x.SaleDate.Hour)
        //                    .OrderBy(x => x.Key)
        //                    .Select(g => new SalesChartModel
        //                    {
        //                        Month = $"{g.Key:00}:00",
        //                        TotalSales = g.Sum(x => x.TotalAmount)
        //                    })
        //                    .ToListAsync();
        //            }

        //        case "This Week":
        //            {
        //                var today = DateTime.Today;

        //                // Monday
        //                int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
        //                var weekStart = today.AddDays(-diff);
        //                var weekEnd = weekStart.AddDays(7);

        //                return await _context.Sales
        //                    .Where(x => x.SaleDate >= weekStart && x.SaleDate < weekEnd)
        //                    .GroupBy(x => x.SaleDate.DayOfWeek)
        //                    .OrderBy(x => x.Key)
        //                    .Select(g => new SalesChartModel
        //                    {
        //                        Month = g.Key.ToString().Substring(0, 3),
        //                        TotalSales = g.Sum(x => x.TotalAmount)
        //                    })
        //                    .ToListAsync();
        //            }

        //        case "This Year":
        //            {
        //                int year = DateTime.Today.Year;

        //                return await _context.Sales
        //                    .Where(x => x.SaleDate.Year == year)
        //                    .GroupBy(x => x.SaleDate.Month)
        //                    .OrderBy(x => x.Key)
        //                    .Select(g => new SalesChartModel
        //                    {
        //                        Month = new DateTime(year, g.Key, 1).ToString("MMM"),
        //                        TotalSales = g.Sum(x => x.TotalAmount)
        //                    })
        //                    .ToListAsync();
        //            }

        //        default: // This Month
        //            {
        //                var today = DateTime.Today;

        //                return await _context.Sales
        //                    .Where(x => x.SaleDate.Month == today.Month &&
        //                                x.SaleDate.Year == today.Year)
        //                    .GroupBy(x => x.SaleDate.Day)
        //                    .OrderBy(x => x.Key)
        //                    .Select(g => new SalesChartModel
        //                    {
        //                        //Month = g.Key.ToString(),
        //                        Month = new DateTime(today.Year, today.Month, g.Key).ToString("dd MMM"),
        //                        TotalSales = g.Sum(x => x.TotalAmount)
        //                    })
        //                    .ToListAsync();
        //            }
        //    }
        //}

        public async Task<List<SalesChartModel>> GetSalesChartAsync(string dt)
        {
            dt = dt?.Trim() ?? "This Month";

            switch (dt)
            {
                case "Today":
                    {
                        var start = DateTime.Today;
                        var end = start.AddDays(1);

                        return await _context.Sales
                            .Where(x => x.SaleDate >= start &&
                                        x.SaleDate < end)
                            .GroupBy(x => x.SaleDate.Hour)
                            .OrderBy(x => x.Key)
                            .Select(g => new SalesChartModel
                            {
                                Month = $"{g.Key:00}:00",
                                TotalSales = g.Sum(x => x.TotalAmount)
                            })
                            .ToListAsync();
                    }

                case "This Week":
                    {
                        var today = DateTime.Today;

                        int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;

                        var weekStart = today.AddDays(-diff);
                        var weekEnd = weekStart.AddDays(7);

                        // SQL se sirf required records lo
                        var sales = await _context.Sales
                            .Where(x => x.SaleDate >= weekStart &&
                                        x.SaleDate < weekEnd)
                            .ToListAsync();

                        // Memory me GroupBy
                        return sales
                            .GroupBy(x => x.SaleDate.DayOfWeek)
                            .OrderBy(x => x.Key)
                            .Select(g => new SalesChartModel
                            {
                                Month = g.Key.ToString().Substring(0, 3),
                                TotalSales = g.Sum(x => x.TotalAmount)
                            })
                            .ToList();
                    }

                case "This Year":
                    {
                        int year = DateTime.Today.Year;

                        var start = new DateTime(year, 1, 1);
                        var end = start.AddYears(1);

                        return await _context.Sales
                            .Where(x => x.SaleDate >= start &&
                                        x.SaleDate < end)
                            .GroupBy(x => x.SaleDate.Month)
                            .OrderBy(x => x.Key)
                            .Select(g => new SalesChartModel
                            {
                                Month = new DateTime(year, g.Key, 1).ToString("MMM"),
                                TotalSales = g.Sum(x => x.TotalAmount)
                            })
                            .ToListAsync();
                    }

                default: // This Month
                    {
                        var today = DateTime.Today;

                        var start = new DateTime(today.Year, today.Month, 1);
                        var end = start.AddMonths(1);

                        return await _context.Sales
                            .Where(x => x.SaleDate >= start &&
                                        x.SaleDate < end)
                            .GroupBy(x => x.SaleDate.Day)
                            .OrderBy(x => x.Key)
                            .Select(g => new SalesChartModel
                            {
                                Month = new DateTime(today.Year, today.Month, g.Key)
                                    .ToString("dd MMM"),

                                TotalSales = g.Sum(x => x.TotalAmount)
                            })
                            .ToListAsync();
                    }
            }
        }


        //public async Task<List<SalesChartModel>> GetSalesChartAsync()
        //{
        //    var sixMonthsAgo = new DateTime(
        //        DateTime.Now.AddMonths(-5).Year,
        //        DateTime.Now.AddMonths(-5).Month,
        //        1);

        //    var data = await _context.Sales
        //        .Where(s => s.SaleDate >= sixMonthsAgo)
        //        .GroupBy(s => new
        //        {
        //            s.SaleDate.Year,
        //            s.SaleDate.Month
        //        })
        //        .OrderBy(g => g.Key.Year)
        //        .ThenBy(g => g.Key.Month)
        //        .Select(g => new
        //        {
        //            g.Key.Year,
        //            g.Key.Month,
        //            TotalSales = g.Sum(x => x.TotalAmount)
        //        })
        //        .ToListAsync();

        //    return data.Select(x => new SalesChartModel
        //    {
        //        Month = new DateTime(x.Year, x.Month, 1).ToString("MMM"),
        //        TotalSales = x.TotalSales
        //    }).ToList();
        //}
        public async Task<List<StockChartModel>> GetStockChartAsync()
        {
            //int inStock = await _context.Products.CountAsync(p =>
            //    p.CurrentStock >= p.MinimumStock);

            //int lowStock = await _context.Products.CountAsync(p =>
            //    p.CurrentStock > 0 &&
            //    p.CurrentStock < p.MinimumStock);

            //int outOfStock = await _context.Products.CountAsync(p =>
            //    p.CurrentStock == 0);
            var products = await _context.Products
    .Select(x => new
    {
        x.ProductName,
        x.CurrentStock,
        x.MinimumStock,
        x.IsActive
    })
    .ToListAsync();

            //MessageBox.Show(
            //    string.Join(Environment.NewLine,
            //        products.Select(x =>
            //            $"{x.ProductName} | Stock={x.CurrentStock} | Min={x.MinimumStock} | Active={x.IsActive}")));
            int inStock = await _context.Products.CountAsync(p =>
    p.IsActive &&
    p.CurrentStock >= p.MinimumStock);

            int lowStock = await _context.Products.CountAsync(p =>
                p.IsActive &&
                p.CurrentStock > 0 &&
                p.CurrentStock < p.MinimumStock);

            int outOfStock = await _context.Products.CountAsync(p =>
                p.IsActive &&
                p.CurrentStock == 0);

            return new List<StockChartModel>
    {
        new StockChartModel { Status = "In Stock", Total = inStock },
        new StockChartModel { Status = "Low Stock", Total = lowStock },
        new StockChartModel { Status = "Out of Stock", Total = outOfStock }
    };
        }

        public async Task<List<RecentSaleModel>> GetRecentSalesAsync()
        {
            return await _context.Sales
                .Include(s => s.Product)
                .OrderByDescending(s => s.SaleDate)
                .Take(10)
                .Select(s => new RecentSaleModel
                {
                    SaleDate = s.SaleDate,
                    ProductName = s.Product.ProductName,
                    Quantity = s.Quantity,
                    TotalAmount = s.TotalAmount
                })
                .ToListAsync();
        }

        //public async Task<List<TopSellingProductModel>> GetTopSellingProductsAsync()
        //{
        //    return await _context.Sales
        //        .Include(s => s.Product)
        //        .GroupBy(s => new
        //        {
        //            s.ProductId,
        //            s.Product.ProductName
        //        })
        //        .Select(g => new TopSellingProductModel
        //        {
        //            ProductName = g.Key.ProductName,
        //            TotalQuantity = g.Sum(x => x.Quantity)
        //        })
        //        .OrderByDescending(x => x.TotalQuantity)
        //        .Take(10)
        //        .ToListAsync();
        //}
        //public async Task<List<TopSellingProductModel>> GetTopSellingProductsAsync()
        //{
        //    var list = await _context.Sales
        //        .Include(x => x.Product)
        //        .GroupBy(x => new
        //        {
        //            x.ProductId,
        //            x.Product.ProductName,
        //            x.Product.ImagePath
        //        })
        //        .Select(g => new TopSellingProductModel
        //        {
        //            ProductName = g.Key.ProductName,
        //            ImagePath = g.Key.ImagePath,
        //            TotalQuantity = g.Sum(x => x.Quantity)
        //        })
        //        .OrderByDescending(x => x.TotalQuantity)
        //        .Take(10)
        //        .ToListAsync();

        //    if (list.Any())
        //    {
        //        int maxQty = list.Max(x => x.TotalQuantity);

        //        foreach (var item in list)
        //        {
        //            item.Progress = maxQty == 0
        //                ? 0
        //                : (item.TotalQuantity * 100) / maxQty;
        //        }
        //    }

        //    return list;
        //}
        public async Task<List<TopSellingProductModel>> GetTopSellingProductsAsync(string duration)
        {
            IQueryable<Sale> query = _context.Sales
                .Include(x => x.Product);

            DateTime today = DateTime.Today;

            switch (duration)
            {
                case "Today":
                    query = query.Where(x => x.CreatedDate.Date == today);
                    break;

                case "This Week":

                    DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);

                    query = query.Where(x => x.CreatedDate >= startOfWeek);

                    break;

                case "This Month":

                    query = query.Where(x =>
                        x.CreatedDate.Month == today.Month &&
                        x.CreatedDate.Year == today.Year);

                    break;

                case "This Year":

                    query = query.Where(x =>
                        x.CreatedDate.Year == today.Year);

                    break;
            }

            var list = await query
                .GroupBy(x => new
                {
                    x.ProductId,
                    x.Product.ProductName,
                    x.Product.ImagePath
                })
                .Select(g => new TopSellingProductModel
                {
                    ProductName = g.Key.ProductName,
                    ImagePath = g.Key.ImagePath,
                    TotalQuantity = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(10)
                .ToListAsync();

            if (list.Any())
            {
                int maxQty = list.Max(x => x.TotalQuantity);

                foreach (var item in list)
                {
                    item.Progress = maxQty == 0
                        ? 0
                        : item.TotalQuantity * 100 / maxQty;
                }
            }

            return list;
        }
    }
}