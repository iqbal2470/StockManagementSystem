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
    public class SalePurchaseDetailRepository : ISalePurchaseDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public SalePurchaseDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SalePurchaseDetail entity)
        {
            await _context.SalePurchaseDetails.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<SalePurchaseDetail> entities)
        {
            await _context.SalePurchaseDetails.AddRangeAsync(entities);
        }

        public async Task<List<SalePurchaseDetail>> GetBySaleIdAsync(int saleId)
        {
            return await _context.SalePurchaseDetails
                .Where(x => x.SaleId == saleId)
                .Include(x => x.Purchase)
                .ToListAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<SalePurchaseDetail> entities)
        {
            _context.SalePurchaseDetails.RemoveRange(entities);

            await Task.CompletedTask;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
