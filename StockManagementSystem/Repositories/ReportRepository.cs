using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Reports;
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
    }
}
