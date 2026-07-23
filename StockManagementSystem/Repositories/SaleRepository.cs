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
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        private readonly ApplicationDbContext _context;

        public SaleRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<Sale?> GetLastSaleAsync()
        {
            return await _context.Sales
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Sale>> SearchSalesAsync(string keyword)
        {
            return await _context.Sales
                .Include(x => x.Product)
                .Where(x =>
                    x.SaleNo.Contains(keyword) ||
                    x.Product.ProductName.Contains(keyword))
                .ToListAsync();
        }

        public async Task<Sale?> GetByIdAsNoTrackingAsync(int id)
        {
            return await _context.Sales
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
