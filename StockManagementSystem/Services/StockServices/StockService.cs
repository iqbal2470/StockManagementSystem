using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.StockServices
{
    public class StockService : IStockService
    {
        private readonly IProductRepository _productRepository;

        public StockService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllStockAsync()
        {
            //return await _productRepository.GetAllAsync();
            return await _productRepository.GetAllStockAsync();
        }

        public async Task<List<Product>> SearchStockAsync(string keyword)
        {
            return await _productRepository.SearchProductsAsync(keyword);
        }

        public async Task<List<Product>> GetLowStockAsync()
        {
            return await _productRepository.GetLowStockAsync();
        }

        public async Task<List<Product>> GetOutOfStockAsync()
        {
            return await _productRepository.GetOutOfStockAsync();
        }


        public async Task<int> GetTotalProductsCountAsync()
        {
            return await _productRepository.GetTotalProductsCountAsync();
        }

        public async Task<int> GetLowStockCountAsync()
        {
            return await _productRepository.GetLowStockCountAsync();
        }

        public async Task<int> GetOutOfStockCountAsync()
        {
            return await _productRepository.GetOutOfStockCountAsync();
        }

        public async Task<int> GetInStockCountAsync()
        {
            return await _productRepository.GetInStockCountAsync();
        }

        public async Task<int> GetCurrentStockQuantityAsync()
        {
            return await _productRepository.GetCurrentStockQuantityAsync();
        }

        //public async Task<List<Product>> GetAllStockAsync()
        //{
        //    return await _productRepository.GetAllStockAsync();
        //}
    }
}
