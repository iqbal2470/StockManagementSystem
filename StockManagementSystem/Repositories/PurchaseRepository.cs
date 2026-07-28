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
    public class PurchaseRepository : GenericRepository<PurchaseEntiity>, IPurchaseRepository
    {
        private readonly ApplicationDbContext _context;

        public PurchaseRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<PurchaseEntiity?> GetLastPurchaseAsync()
        {
            return await _context.Purchases
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<PurchaseEntiity>> SearchPurchasesAsync(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return await _context.Purchases
        .Include(x => x.Product)
        .Where(x =>
            x.PurchaseNo.ToLower().Contains(keyword) ||
            x.Product.ProductName.ToLower().Contains(keyword))
        .OrderByDescending(x => x.Id)
        .ToListAsync();

            //return await _context.Purchases
            //    .Include(x => x.Product)
            //    .Where(x =>
            //        x.PurchaseNo.ToLower().Contains(keyword) ||
            //        x.Product.ProductName.ToLower().Contains(keyword))
            //    .OrderByDescending(x => x.Id)
            //    .ToListAsync();
        }

        public async Task<PurchaseEntiity?> GetByIdAsNoTrackingAsync(int id)
        {
            return await _context.Purchases
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PurchaseEntiity?> GetOldestAvailablePurchaseAsync(int productId)
        {
            return await _context.Purchases
                .Where(x => x.ProductId == productId &&
                            x.RemainingQuantity > 0)
                .OrderBy(x => x.PurchaseDate)
                .ThenBy(x => x.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<PurchaseEntiity>> GetAvailablePurchasesAsync(int productId)
        {
            return await _context.Purchases
                .Where(x => x.ProductId == productId &&
                            x.RemainingQuantity > 0)
                .OrderBy(x => x.PurchaseDate)
                .ThenBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<PurchaseEntiity?> GetLatestPurchaseByProductAsync(int productId)
        {
            return await _context.Purchases
                .Where(x => x.ProductId == productId)
                .OrderByDescending(x => x.PurchaseDate)
                .ThenByDescending(x => x.Id)
                .FirstOrDefaultAsync();
        }

    }
}
