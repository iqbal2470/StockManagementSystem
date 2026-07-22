using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface ISaleRepository : IGenericRepository<Sale>
    {
        Task<Sale?> GetLastSaleAsync();

        Task<List<Sale>> SearchSalesAsync(string keyword);
    }
}
