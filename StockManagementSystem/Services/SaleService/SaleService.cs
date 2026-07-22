using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.SaleService
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;

        public SaleService(
            ISaleRepository saleRepository,
            IProductRepository productRepository)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
        }

        public async Task<List<Sale>> GetAllSalesAsync()
        {
            return await _saleRepository.GetAllAsync();
        }

        public async Task<Sale?> GetSaleByIdAsync(int id)
        {
            return await _saleRepository.GetByIdAsync(id);
        }

        public async Task<string> GenerateSaleNumberAsync()
        {
            var lastSale = await _saleRepository.GetLastSaleAsync();

            if (lastSale == null)
                return "SAL0001";

            string lastNo = lastSale.SaleNo.Replace("SAL", "");

            if (!int.TryParse(lastNo, out int number))
                number = 0;

            number++;

            return $"SAL{number:D4}";
        }

        public async Task AddSaleAsync(Sale sale)
        {
            var product = await _productRepository.GetByIdAsync(sale.ProductId);

            if (product == null)
                throw new Exception("Product not found.");

            if (product.CurrentStock < sale.Quantity)
                throw new Exception("Insufficient stock.");

            product.CurrentStock -= sale.Quantity;

            await _productRepository.UpdateAsync(product);

            await _saleRepository.AddAsync(sale);
        }

        public async Task UpdateSaleAsync(Sale sale)
        {
            var oldSale = await _saleRepository.GetByIdAsync(sale.Id);

            if (oldSale == null)
                throw new Exception("Sale not found.");

            // Same Product
            if (oldSale.ProductId == sale.ProductId)
            {
                var product = await _productRepository.GetByIdAsync(sale.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                // Restore previous stock
                product.CurrentStock += oldSale.Quantity;

                // Check stock
                if (product.CurrentStock < sale.Quantity)
                    throw new Exception("Insufficient stock.");

                // Deduct new quantity
                product.CurrentStock -= sale.Quantity;

                await _productRepository.UpdateAsync(product);
            }
            else
            {
                // Restore old product stock
                var oldProduct = await _productRepository.GetByIdAsync(oldSale.ProductId);

                if (oldProduct != null)
                {
                    oldProduct.CurrentStock += oldSale.Quantity;
                    await _productRepository.UpdateAsync(oldProduct);
                }

                // Deduct from new product
                var newProduct = await _productRepository.GetByIdAsync(sale.ProductId);

                if (newProduct == null)
                    throw new Exception("Product not found.");

                if (newProduct.CurrentStock < sale.Quantity)
                    throw new Exception("Insufficient stock.");

                newProduct.CurrentStock -= sale.Quantity;

                await _productRepository.UpdateAsync(newProduct);
            }

            await _saleRepository.UpdateAsync(sale);
        }

        public async Task DeleteSaleAsync(int id)
        {
            var sale = await _saleRepository.GetByIdAsync(id);

            if (sale == null)
                throw new Exception("Sale not found.");

            var product = await _productRepository.GetByIdAsync(sale.ProductId);

            if (product != null)
            {
                product.CurrentStock += sale.Quantity;

                await _productRepository.UpdateAsync(product);
            }

            await _saleRepository.DeleteAsync(sale);
        }

        public async Task<List<Sale>> SearchSalesAsync(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return await _saleRepository.GetAllAsync();

            return await _saleRepository.SearchSalesAsync(keyword);
        }
    }
}
