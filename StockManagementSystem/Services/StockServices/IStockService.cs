using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.StockServices
{
    public interface IStockService
    {
        Task<List<Product>> GetAllStockAsync();

        Task<List<Product>> SearchStockAsync(string keyword);

        Task<List<Product>> GetLowStockAsync();

        Task<List<Product>> GetOutOfStockAsync();

        Task<int> GetTotalProductsCountAsync();

        Task<int> GetLowStockCountAsync();

        Task<int> GetOutOfStockCountAsync();

        Task<int> GetInStockCountAsync();

        Task<int> GetCurrentStockQuantityAsync();



    }
}
