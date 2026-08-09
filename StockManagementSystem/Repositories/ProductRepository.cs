using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .AsNoTracking()
                .Where(x => x.IsActive)
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.Unit)
                .OrderBy(x => x.ProductName)
                .ToListAsync();
        }

        public async Task<Product?> GetLastProductAsync()
        {
            return await _context.Products
                .OrderByDescending(p => p.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Product>> SearchProductsAsync(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.Unit)
                .Where(p => p.IsActive &&
                        (
                            p.ProductName.ToLower().Contains(keyword) ||
                            p.ProductCode.ToLower().Contains(keyword) ||
                            (p.Barcode != null && p.Barcode.ToLower().Contains(keyword)) ||
                            (p.VehicleModel != null && p.VehicleModel.ToLower().Contains(keyword))
                        ))
                        .OrderBy(p => p.ProductName)
                        .ToListAsync();
//.Where(p => p.IsActive &&
//                    p.ProductName.ToLower().Contains(keyword) ||
//                    p.ProductCode.ToLower().Contains(keyword) ||
//                    (p.Barcode != null && p.Barcode.ToLower().Contains(keyword)) ||
//                    (p.VehicleModel != null && p.VehicleModel.ToLower().Contains(keyword))
//                    )
            
        }
        public async Task<Product?> GetLastProductByBarcodeAsync()
        {
            return await _context.Products
                .Where(p => !string.IsNullOrEmpty(p.Barcode))
                .OrderByDescending(p => p.Id)
                .FirstOrDefaultAsync();
        }


        public async Task<List<Product>> GetLowStockAsync()
        {
            return await _context.Products
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.Unit)
                .Where(x => x.IsActive && x.CurrentStock > 0 && x.CurrentStock < x.MinimumStock)
                .ToListAsync();
        }

        public async Task<List<Product>> GetOutOfStockAsync()
        {
            return await _context.Products
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.Unit)
                .Where(x => x.IsActive && x.CurrentStock == 0)
                .ToListAsync();
        }


        public async Task<int> GetTotalProductsCountAsync()
        {
            return await _context.Products.CountAsync(x => x.IsActive);
        }

        //public async Task<int> GetLowStockCountAsync()
        //{
        //    return await _context.Products
        //        .CountAsync(x => x.IsActive && x.CurrentStock < x.MinimumStock);
        //}

        public async Task<int> GetLowStockCountAsync()
        {
            return await _context.Products
                .CountAsync(x =>
                    x.IsActive &&
                    x.CurrentStock > 0 &&
                    x.CurrentStock < x.MinimumStock);
        }

        public async Task<int> GetOutOfStockCountAsync()
        {
            return await _context.Products
                .CountAsync(x => x.IsActive && x.CurrentStock == 0);
        }

        public async Task<int> GetInStockCountAsync()
        {
            return await _context.Products
                .CountAsync(x => x.IsActive && x.CurrentStock >= x.MinimumStock);
            //.CountAsync(x => x.CurrentStock > 0);
        }

        public async Task<int> GetCurrentStockQuantityAsync()
        {
            return await _context.Products
                .Where(x => x.IsActive)
                .SumAsync(x => (int?)x.CurrentStock) ?? 0;
        }

        public async Task<List<Product>> GetAllStockAsync()
        {
            return await _context.Products
                .Where(x => x.IsActive)
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.Unit)
                .OrderBy(x => x.ProductName)
                .ToListAsync();
        }
    }
}
