using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface IPurchaseRepository : IGenericRepository<PurchaseEntiity>
    {
        Task<PurchaseEntiity?> GetLastPurchaseAsync();

        Task<List<PurchaseEntiity>> SearchPurchasesAsync(string keyword);

        Task<PurchaseEntiity?> GetByIdAsNoTrackingAsync(int id);

        Task<PurchaseEntiity?> GetOldestAvailablePurchaseAsync(int productId);

        Task<List<PurchaseEntiity>> GetAvailablePurchasesAsync(int productId);

        Task<PurchaseEntiity?> GetLatestPurchaseByProductAsync(int productId);

    }
}
