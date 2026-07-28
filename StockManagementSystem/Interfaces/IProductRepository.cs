using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetLastProductAsync();

        Task<List<Product>> SearchProductsAsync(string keyword);

        Task<Product?> GetLastProductByBarcodeAsync();


        Task<List<Product>> GetLowStockAsync();

        Task<List<Product>> GetOutOfStockAsync();

        Task<int> GetTotalProductsCountAsync();

        Task<int> GetLowStockCountAsync();

        Task<int> GetOutOfStockCountAsync();

        Task<int> GetInStockCountAsync();

        Task<int> GetCurrentStockQuantityAsync();

        Task<List<Product>> GetAllStockAsync();
    }
}
