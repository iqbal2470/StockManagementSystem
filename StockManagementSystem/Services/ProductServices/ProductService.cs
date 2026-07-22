using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            await _productRepository.SaveAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
            await _productRepository.SaveAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product != null)
            {
                await _productRepository.DeleteAsync(product);
                await _productRepository.SaveAsync();
            }
        }

        //public async Task<string> GenerateProductCodeAsync()
        //{
        //    var lastProduct = await _productRepository.GetLastProductAsync();

        //    if (lastProduct == null || string.IsNullOrWhiteSpace(lastProduct.ProductCode))
        //    {
        //        return "PRD0001";
        //    }

        //    int number = int.Parse(lastProduct.ProductCode.Replace("PRD", ""));

        //    number++;

        //    return $"PRD{number:D4}";
        //}

        public async Task<string> GenerateProductCodeAsync()
        {
            var lastProduct = await _productRepository.GetLastProductAsync();

            if (lastProduct == null || string.IsNullOrWhiteSpace(lastProduct.ProductCode))
                return "PRD0001";

            if (!int.TryParse(lastProduct.ProductCode.Replace("PRD", ""), out int number))
                return "PRD0001";

            number++;

            return $"PRD{number:D4}";
        }


        public async Task<List<Product>> SearchProductsAsync(string keyword)
        {
            return await _productRepository.SearchProductsAsync(keyword);
        }

        public async Task<string> GenerateBarcodeAsync()
        {
            var lastProduct = await _productRepository.GetLastProductByBarcodeAsync();

            if (lastProduct == null || string.IsNullOrWhiteSpace(lastProduct.Barcode))
                return "900000000001";

            if (!long.TryParse(lastProduct.Barcode, out long barcode))
                return "900000000001";

            barcode++;

            return barcode.ToString();
        }
    }
}
