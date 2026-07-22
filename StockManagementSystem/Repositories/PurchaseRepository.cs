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
        }


    }
}
