using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface ISalePurchaseDetailRepository
    {
        Task AddAsync(SalePurchaseDetail entity);

        Task AddRangeAsync(IEnumerable<SalePurchaseDetail> entities);

        Task<List<SalePurchaseDetail>> GetBySaleIdAsync(int saleId);

        Task DeleteRangeAsync(IEnumerable<SalePurchaseDetail> entities);

        Task SaveAsync();
    }
}
