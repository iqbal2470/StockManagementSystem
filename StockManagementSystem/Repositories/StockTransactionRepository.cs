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
    public class StockTransactionRepository
    : GenericRepository<StockTransaction>, IStockTransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public StockTransactionRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<StockTransaction>> GetRecentTransactionsAsync(int count)
        {
            return await _context.StockTransactions
                .Include(x => x.Product)
                .OrderByDescending(x => x.CreatedDate)
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<StockTransaction>> GetProductHistoryAsync(int productId)
        {
            return await _context.StockTransactions
                .Include(x => x.Product)
                .Where(x => x.ProductId == productId)
                .OrderByDescending(x => x.CreatedDate)
                .ToListAsync();
        }

        public async Task<List<StockTransaction>> GetAllHistoryAsync()
        {
            return await _context.StockTransactions
                .Include(x => x.Product)
                .OrderByDescending(x => x.CreatedDate)
                .ToListAsync();
        }
    }
}
