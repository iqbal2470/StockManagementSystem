using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.PurchaseService
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IProductRepository _productRepository;
        public PurchaseService(IPurchaseRepository purchaseRepository, IProductRepository productRepository)
        {
            _purchaseRepository = purchaseRepository;
            _productRepository = productRepository;
        }

        public async Task<List<PurchaseEntiity>> GetAllPurchasesAsync()
        {
            return await _purchaseRepository.GetAllAsync();
        }

        public async Task<PurchaseEntiity?> GetPurchaseByIdAsync(int id)
        {
            return await _purchaseRepository.GetByIdAsync(id);
        }

        public async Task AddPurchaseAsync(PurchaseEntiity purchase)
        {
            // Purchase Save
            await _purchaseRepository.AddAsync(purchase);

            // Product Load
            var product = await _productRepository.GetByIdAsync(purchase.ProductId);

            if (product != null)
            {
                product.CurrentStock += purchase.Quantity;

                await _productRepository.UpdateAsync(product);
            }
        }

        //public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        //{
        //    await _purchaseRepository.UpdateAsync(purchase);
        //}

        public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        {
            var oldPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);

            if (oldPurchase == null)
                return;

            if (oldPurchase.ProductId == purchase.ProductId)
            {
                // Same Product
                var product = await _productRepository.GetByIdAsync(purchase.ProductId);

                if (product != null)
                {
                    product.CurrentStock -= oldPurchase.Quantity;
                    product.CurrentStock += purchase.Quantity;

                    await _productRepository.UpdateAsync(product);
                }
            }
            else
            {
                // Old Product
                var oldProduct = await _productRepository.GetByIdAsync(oldPurchase.ProductId);

                if (oldProduct != null)
                {
                    oldProduct.CurrentStock -= oldPurchase.Quantity;
                    await _productRepository.UpdateAsync(oldProduct);
                }

                // New Product
                var newProduct = await _productRepository.GetByIdAsync(purchase.ProductId);

                if (newProduct != null)
                {
                    newProduct.CurrentStock += purchase.Quantity;
                    await _productRepository.UpdateAsync(newProduct);
                }
            }

            await _purchaseRepository.UpdateAsync(purchase);
        }

        //public async Task DeletePurchaseAsync(int id)
        //{
        //    var purchase = await _purchaseRepository.GetByIdAsync(id);

        //    if (purchase != null)
        //    {
        //        await _purchaseRepository.DeleteAsync(purchase);
        //    }
        //}

        public async Task DeletePurchaseAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);

            if (purchase == null)
                return;

            var product = await _productRepository.GetByIdAsync(purchase.ProductId);

            if (product != null)
            {
                product.CurrentStock -= purchase.Quantity;

                await _productRepository.UpdateAsync(product);
            }

            await _purchaseRepository.DeleteAsync(purchase);
        }

        public async Task<List<PurchaseEntiity>> SearchPurchasesAsync(string keyword)
        {
            return await _purchaseRepository.SearchPurchasesAsync(keyword);
        }

        public async Task<string> GeneratePurchaseNumberAsync()
        {
            var lastPurchase = await _purchaseRepository.GetLastPurchaseAsync();

            if (lastPurchase == null || string.IsNullOrWhiteSpace(lastPurchase.PurchaseNo))
                return "PUR0001";

            if (!int.TryParse(lastPurchase.PurchaseNo.Replace("PUR", ""), out int number))
                return "PUR0001";

            number++;

            return $"PUR{number:D4}";
        }
    }
}
