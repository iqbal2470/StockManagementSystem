using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.PurchaseService
{
    public interface IPurchaseService
    {
        Task<List<PurchaseEntiity>> GetAllPurchasesAsync();

        Task<PurchaseEntiity?> GetPurchaseByIdAsync(int id);

        Task AddPurchaseAsync(PurchaseEntiity purchase);

        Task UpdatePurchaseAsync(PurchaseEntiity purchase);

        Task DeletePurchaseAsync(int id);

        Task<List<PurchaseEntiity>> SearchPurchasesAsync(string keyword);

        Task<string> GeneratePurchaseNumberAsync();

    }
    }
