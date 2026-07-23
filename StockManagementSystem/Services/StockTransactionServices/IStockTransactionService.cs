using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.StockTransactionServices
{
    public interface IStockTransactionService
    {
        Task AddTransactionAsync(
            int productId,
            TransactionType transactionType,
            int quantity,
            int previousStock,
            int currentStock,
            string? referenceNo = null,
            string? remarks = null,
            string? referenceType = null);

        Task<List<StockTransaction>> GetRecentTransactionsAsync(int count);

        Task<List<StockTransaction>> GetProductHistoryAsync(int productId);

        Task<List<StockTransaction>> GetAllHistoryAsync();
    }
}
