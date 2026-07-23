using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.StockTransactionServices
{
    public class StockTransactionService : IStockTransactionService
    {
        private readonly IStockTransactionRepository _repository;

        public StockTransactionService(IStockTransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task AddTransactionAsync(
            int productId,
            TransactionType transactionType,
            int quantity,
            int previousStock,
            int currentStock,
            string? referenceNo = null,
            string? remarks = null,
            string? referenceType = null)
        {
            var transaction = new StockTransaction
            {
                ProductId = productId,
                TransactionType = transactionType,
                Quantity = quantity,
                PreviousStock = previousStock,
                CurrentStock = currentStock,
                ReferenceNo = referenceNo,
                Remarks = remarks,
                ReferenceType = referenceType
            };

            await _repository.AddAsync(transaction);

            await _repository.SaveAsync();
        }

        public async Task<List<StockTransaction>> GetRecentTransactionsAsync(int count)
        {
            return await _repository.GetRecentTransactionsAsync(count);
        }

        public async Task<List<StockTransaction>> GetProductHistoryAsync(int productId)
        {
            return await _repository.GetProductHistoryAsync(productId);
        }

        public async Task<List<StockTransaction>> GetAllHistoryAsync()
        {
            return await _repository.GetAllHistoryAsync();
        }
    }
}
