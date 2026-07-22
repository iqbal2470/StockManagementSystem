using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.SaleService
{
    public interface ISaleService
    {
        Task<List<Sale>> GetAllSalesAsync();

        Task<Sale?> GetSaleByIdAsync(int id);

        Task AddSaleAsync(Sale sale);

        Task UpdateSaleAsync(Sale sale);

        Task DeleteSaleAsync(int id);

        Task<List<Sale>> SearchSalesAsync(string keyword);

        Task<string> GenerateSaleNumberAsync();
    }
}
