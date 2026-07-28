using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<Product?> GetProductByIdAsync(int id);

        Task AddProductAsync(Product product);

        Task UpdateProductAsync(Product product);

        Task DeleteProductAsync(int id);

        Task<string> GenerateProductCodeAsync();

        Task<List<Product>> SearchProductsAsync(string keyword);

        Task<string> GenerateBarcodeAsync();

        Task<int> GetTotalProductsCountAsync();
        Task<int> GetInStockCountAsync();
        Task<int> GetLowStockCountAsync();
        Task<int> GetOutOfStockCountAsync();

        Task<int> GetCurrentStockQuantityAsync();
    }
}
