using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface IStockTransactionRepository : IGenericRepository<StockTransaction>
    {
        Task<List<StockTransaction>> GetRecentTransactionsAsync(int count);

        Task<List<StockTransaction>> GetProductHistoryAsync(int productId);

        Task<List<StockTransaction>> GetAllHistoryAsync();
    }
}
