using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.StockTransactionServices;
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
        private readonly IStockTransactionService _stockTransactionService;
        public PurchaseService(IPurchaseRepository purchaseRepository, IProductRepository productRepository, IStockTransactionService stockTransactionService)
        {
            _purchaseRepository = purchaseRepository;
            _productRepository = productRepository;
            _stockTransactionService = stockTransactionService;
        }

        public async Task<List<PurchaseEntiity>> GetAllPurchasesAsync()
        {
            return await _purchaseRepository.GetAllAsync();
        }

        public async Task<PurchaseEntiity?> GetPurchaseByIdAsync(int id)
        {
            return await _purchaseRepository.GetByIdAsync(id);
        }

        //public async Task AddPurchaseAsync(PurchaseEntiity purchase)
        //{
        //    // Purchase Save
        //    await _purchaseRepository.AddAsync(purchase);

        //    // Product Load
        //    var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //    if (product != null)
        //    {
        //        product.CurrentStock += purchase.Quantity;

        //        await _productRepository.UpdateAsync(product);
        //    }
        //}
        public async Task AddPurchaseAsync(PurchaseEntiity purchase)
        {
            // Purchase Save
            await _purchaseRepository.AddAsync(purchase);

            // Product Load
            var product = await _productRepository.GetByIdAsync(purchase.ProductId);

            if (product == null)
                throw new Exception("Product not found.");

            int previousStock = product.CurrentStock;

            product.CurrentStock += purchase.Quantity;

            await _productRepository.UpdateAsync(product);

            await _stockTransactionService.AddTransactionAsync(
                productId: product.Id,
                transactionType: TransactionType.Purchase,
                quantity: purchase.Quantity,
                previousStock: previousStock,
                currentStock: product.CurrentStock,
                referenceNo: purchase.PurchaseNo,
                remarks: purchase.Remarks,
                referenceType: "Purchase"
            );
        }
        //public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        //{
        //    await _purchaseRepository.UpdateAsync(purchase);
        //}

        //public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        //{
        //    var oldPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);

        //    if (oldPurchase == null)
        //        return;

        //    if (oldPurchase.ProductId == purchase.ProductId)
        //    {
        //        // Same Product
        //        var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //        if (product != null)
        //        {
        //            product.CurrentStock -= oldPurchase.Quantity;
        //            product.CurrentStock += purchase.Quantity;

        //            await _productRepository.UpdateAsync(product);
        //        }
        //    }
        //    else
        //    {
        //        // Old Product
        //        var oldProduct = await _productRepository.GetByIdAsync(oldPurchase.ProductId);

        //        if (oldProduct != null)
        //        {
        //            oldProduct.CurrentStock -= oldPurchase.Quantity;
        //            await _productRepository.UpdateAsync(oldProduct);
        //        }

        //        // New Product
        //        var newProduct = await _productRepository.GetByIdAsync(purchase.ProductId);

        //        if (newProduct != null)
        //        {
        //            newProduct.CurrentStock += purchase.Quantity;
        //            await _productRepository.UpdateAsync(newProduct);
        //        }
        //    }

        //    await _purchaseRepository.UpdateAsync(purchase);


        //}

        public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        {
            //var oldPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);
            var oldPurchase = await _purchaseRepository.GetByIdAsNoTrackingAsync(purchase.Id);

            if (oldPurchase == null)
                throw new Exception("Purchase not found.");

            // ===========================
            // Same Product
            // ===========================
            if (oldPurchase.ProductId == purchase.ProductId)
            {
                var product = await _productRepository.GetByIdAsync(purchase.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                int previousStock = product.CurrentStock;

                // Reverse old quantity
                product.CurrentStock -= oldPurchase.Quantity;

                // Add new quantity
                product.CurrentStock += purchase.Quantity;

                await _productRepository.UpdateAsync(product);

                await _stockTransactionService.AddTransactionAsync(
                    productId: product.Id,
                    transactionType: TransactionType.PurchaseUpdate,
                    quantity: purchase.Quantity,
                    previousStock: previousStock,
                    currentStock: product.CurrentStock,
                    referenceNo: purchase.PurchaseNo,
                    remarks: $"Purchase Updated (Old Qty: {oldPurchase.Quantity}, New Qty: {purchase.Quantity})",
                    referenceType: "Purchase"
                );
            }
            // ===========================
            // Product Changed
            // ===========================
            else
            {
                // Old Product
                var oldProduct = await _productRepository.GetByIdAsync(oldPurchase.ProductId);

                if (oldProduct == null)
                    throw new Exception("Old Product not found.");

                int oldPreviousStock = oldProduct.CurrentStock;

                oldProduct.CurrentStock -= oldPurchase.Quantity;

                await _productRepository.UpdateAsync(oldProduct);

                await _stockTransactionService.AddTransactionAsync(
                    productId: oldProduct.Id,
                    transactionType: TransactionType.PurchaseDelete,
                    quantity: oldPurchase.Quantity,
                    previousStock: oldPreviousStock,
                    currentStock: oldProduct.CurrentStock,
                    referenceNo: oldPurchase.PurchaseNo,
                    remarks: "Purchase moved to another product",
                    referenceType: "Purchase"
                );

                // New Product
                var newProduct = await _productRepository.GetByIdAsync(purchase.ProductId);

                if (newProduct == null)
                    throw new Exception("New Product not found.");

                int newPreviousStock = newProduct.CurrentStock;

                newProduct.CurrentStock += purchase.Quantity;

                await _productRepository.UpdateAsync(newProduct);

                await _stockTransactionService.AddTransactionAsync(
                    productId: newProduct.Id,
                    transactionType: TransactionType.PurchaseUpdate,
                    quantity: purchase.Quantity,
                    previousStock: newPreviousStock,
                    currentStock: newProduct.CurrentStock,
                    referenceNo: purchase.PurchaseNo,
                    remarks: "Purchase moved from another product",
                    referenceType: "Purchase"
                );
            }

            // Update Purchase Record
            //await _purchaseRepository.UpdateAsync(purchase);
            var dbPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);

            if (dbPurchase == null)
                throw new Exception("Purchase not found.");

            dbPurchase.PurchaseNo = purchase.PurchaseNo;
            dbPurchase.PurchaseDate = purchase.PurchaseDate;
            dbPurchase.ProductId = purchase.ProductId;
            dbPurchase.PurchasePrice = purchase.PurchasePrice;
            dbPurchase.Quantity = purchase.Quantity;
            dbPurchase.TotalAmount = purchase.TotalAmount;
            dbPurchase.Remarks = purchase.Remarks;

            await _purchaseRepository.UpdateAsync(dbPurchase);
        }

        //public async Task DeletePurchaseAsync(int id)
        //{
        //    var purchase = await _purchaseRepository.GetByIdAsync(id);

        //    if (purchase != null)
        //    {
        //        await _purchaseRepository.DeleteAsync(purchase);
        //    }
        //}

        //public async Task DeletePurchaseAsync(int id)
        //{
        //    var purchase = await _purchaseRepository.GetByIdAsync(id);

        //    if (purchase == null)
        //        return;

        //    var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //    if (product != null)
        //    {
        //        product.CurrentStock -= purchase.Quantity;

        //        await _productRepository.UpdateAsync(product);
        //    }

        //    await _purchaseRepository.DeleteAsync(purchase);
        //}

        public async Task DeletePurchaseAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);

            if (purchase == null)
                return;

            var product = await _productRepository.GetByIdAsync(purchase.ProductId);

            if (product == null)
                throw new Exception("Product not found.");

            int previousStock = product.CurrentStock;

            // Purchase delete hone par stock kam hoga
            product.CurrentStock -= purchase.Quantity;

            await _productRepository.UpdateAsync(product);

            // Stock Transaction Entry
            await _stockTransactionService.AddTransactionAsync(
                productId: product.Id,
                transactionType: TransactionType.PurchaseDelete,
                quantity: purchase.Quantity,
                previousStock: previousStock,
                currentStock: product.CurrentStock,
                referenceNo: purchase.PurchaseNo,
                remarks: $"Purchase Deleted (Qty: {purchase.Quantity})",
                referenceType: "Purchase"
            );

            // Purchase Delete
            await _purchaseRepository.DeleteAsync(purchase);

            // Database Save
            await _purchaseRepository.SaveAsync();
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
