using StockManagementSystem.Data;
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
        private readonly ApplicationDbContext _context;
        public PurchaseService(IPurchaseRepository purchaseRepository, IProductRepository productRepository, IStockTransactionService stockTransactionService, ApplicationDbContext context)
        {
            _purchaseRepository = purchaseRepository;
            _productRepository = productRepository;
            _stockTransactionService = stockTransactionService;
            _context = context;
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
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                //-------------------------------------------------------
                // Validate Purchase
                //-------------------------------------------------------

                if (purchase == null)
                    throw new Exception("Purchase data is invalid.");

                //-------------------------------------------------------
                // Product
                //-------------------------------------------------------

                var product = await _productRepository.GetByIdAsync(purchase.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                //-------------------------------------------------------
                // Initialize Purchase
                //-------------------------------------------------------

                purchase.RemainingQuantity = purchase.Quantity;

                if (purchase.CreatedDate == default)
                    purchase.CreatedDate = DateTime.Now;

                int previousStock = product.CurrentStock;

                //-------------------------------------------------------
                // Update Product Stock
                //-------------------------------------------------------

                //product.CurrentStock += purchase.Quantity;

                IncreaseStock(product, purchase.Quantity);

                //-------------------------------------------------------
                // Save Purchase
                //-------------------------------------------------------

                await _purchaseRepository.AddAsync(purchase);

                //-------------------------------------------------------
                // Update Product Purchase Price
                //-------------------------------------------------------

                product.PurchasePrice = purchase.PurchasePrice;

                //-------------------------------------------------------
                // Update Product
                //-------------------------------------------------------

                await _productRepository.UpdateAsync(product);

                //-------------------------------------------------------
                // Stock Transaction
                //-------------------------------------------------------

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

                //-------------------------------------------------------
                // Save Changes
                //-------------------------------------------------------

                await _context.SaveChangesAsync();

                //-------------------------------------------------------
                // Commit
                //-------------------------------------------------------

                await transaction.CommitAsync();
            }
            catch
            {
                //-------------------------------------------------------
                // Rollback
                //-------------------------------------------------------

                await transaction.RollbackAsync();
                throw;
            }
        }
        //public async Task AddPurchaseAsync(PurchaseEntiity purchase)
        //{
        //    purchase.RemainingQuantity = purchase.Quantity;

        //    // Purchase Save
        //    await _purchaseRepository.AddAsync(purchase);

        //    // Product Load
        //    var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //    if (product == null)
        //        throw new Exception("Product not found.");

        //    int previousStock = product.CurrentStock;

        //    product.CurrentStock += purchase.Quantity;

        //    await _productRepository.UpdateAsync(product);
        //    await _purchaseRepository.SaveAsync();
        //    await _stockTransactionService.AddTransactionAsync(
        //        productId: product.Id,
        //        transactionType: TransactionType.Purchase,
        //        quantity: purchase.Quantity,
        //        previousStock: previousStock,
        //        currentStock: product.CurrentStock,
        //        referenceNo: purchase.PurchaseNo,
        //        remarks: purchase.Remarks,
        //        referenceType: "Purchase"
        //    );
        //}
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


        //public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        //{
        //    var oldPurchase = await _purchaseRepository.GetByIdAsNoTrackingAsync(purchase.Id);

        //    if (oldPurchase == null)
        //        throw new Exception("Purchase not found.");

        //    // Purchase already used in Sale
        //    if (oldPurchase.RemainingQuantity != oldPurchase.Quantity)
        //        throw new Exception("This purchase is already used in Sale. Update not allowed.");

        //    // ==================================================
        //    // SAME PRODUCT
        //    // ==================================================
        //    if (oldPurchase.ProductId == purchase.ProductId)
        //    {
        //        var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //        if (product == null)
        //            throw new Exception("Product not found.");

        //        int previousStock = product.CurrentStock;

        //        // Remove old quantity
        //        product.CurrentStock -= oldPurchase.Quantity;

        //        // Add new quantity
        //        product.CurrentStock += purchase.Quantity;

        //        await _productRepository.UpdateAsync(product);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: product.Id,
        //            transactionType: TransactionType.PurchaseUpdate,
        //            quantity: purchase.Quantity,
        //            previousStock: previousStock,
        //            currentStock: product.CurrentStock,
        //            referenceNo: purchase.PurchaseNo,
        //            remarks: $"Purchase Updated (Old Qty: {oldPurchase.Quantity}, New Qty: {purchase.Quantity})",
        //            referenceType: "Purchase"
        //        );
        //    }
        //    // ==================================================
        //    // PRODUCT CHANGED
        //    // ==================================================
        //    else
        //    {
        //        // Restore old product stock
        //        var oldProduct = await _productRepository.GetByIdAsync(oldPurchase.ProductId);

        //        if (oldProduct == null)
        //            throw new Exception("Old Product not found.");

        //        int oldPreviousStock = oldProduct.CurrentStock;

        //        oldProduct.CurrentStock -= oldPurchase.Quantity;

        //        await _productRepository.UpdateAsync(oldProduct);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: oldProduct.Id,
        //            transactionType: TransactionType.PurchaseDelete,
        //            quantity: oldPurchase.Quantity,
        //            previousStock: oldPreviousStock,
        //            currentStock: oldProduct.CurrentStock,
        //            referenceNo: oldPurchase.PurchaseNo,
        //            remarks: "Purchase moved to another product",
        //            referenceType: "Purchase"
        //        );

        //        // Add stock to new product
        //        var newProduct = await _productRepository.GetByIdAsync(purchase.ProductId);

        //        if (newProduct == null)
        //            throw new Exception("New Product not found.");

        //        int newPreviousStock = newProduct.CurrentStock;

        //        newProduct.CurrentStock += purchase.Quantity;

        //        await _productRepository.UpdateAsync(newProduct);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: newProduct.Id,
        //            transactionType: TransactionType.PurchaseUpdate,
        //            quantity: purchase.Quantity,
        //            previousStock: newPreviousStock,
        //            currentStock: newProduct.CurrentStock,
        //            referenceNo: purchase.PurchaseNo,
        //            remarks: "Purchase moved from another product",
        //            referenceType: "Purchase"
        //        );
        //    }

        //    // ==================================================
        //    // UPDATE PURCHASE RECORD
        //    // ==================================================
        //    var dbPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);

        //    if (dbPurchase == null)
        //        throw new Exception("Purchase not found.");

        //    dbPurchase.PurchaseNo = purchase.PurchaseNo;
        //    dbPurchase.PurchaseDate = purchase.PurchaseDate;
        //    dbPurchase.ProductId = purchase.ProductId;
        //    dbPurchase.PurchasePrice = purchase.PurchasePrice;
        //    dbPurchase.Quantity = purchase.Quantity;

        //    // Safe because update is allowed only when no sale has used this purchase.
        //    dbPurchase.RemainingQuantity = purchase.Quantity;

        //    dbPurchase.TotalAmount = purchase.TotalAmount;
        //    dbPurchase.Remarks = purchase.Remarks;
        //    dbPurchase.UpdatedDate = DateTime.Now;

        //    await _purchaseRepository.UpdateAsync(dbPurchase);

        //    await _purchaseRepository.SaveAsync();
        //}

        public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        {
            await using var transaction =
                await _context.Database.BeginTransactionAsync();

            try
            {
                //-------------------------------------------------------
                // Existing Purchase
                //-------------------------------------------------------

                var dbPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);

                if (dbPurchase == null)
                    throw new Exception("Purchase not found.");

                //-------------------------------------------------------
                // Purchase Already Used?
                //-------------------------------------------------------

                if (dbPurchase.RemainingQuantity != dbPurchase.Quantity)
                    throw new Exception(
                        "This purchase is already used in Sale. Update not allowed.");

                //-------------------------------------------------------
                // SAME PRODUCT
                //-------------------------------------------------------

                if (dbPurchase.ProductId == purchase.ProductId)
                {
                    var product = await _productRepository
                        .GetByIdAsync(dbPurchase.ProductId);

                    if (product == null)
                        throw new Exception("Product not found.");

                    int previousStock = product.CurrentStock;

                    //---------------------------------------------------
                    // Restore Old Stock
                    //---------------------------------------------------

                    //product.CurrentStock -= dbPurchase.Quantity;
                    DecreaseStock(product, dbPurchase.Quantity);

                    //---------------------------------------------------
                    // Add New Stock
                    //---------------------------------------------------
                    IncreaseStock(product, purchase.Quantity);

                    //product.CurrentStock += purchase.Quantity;

                    //---------------------------------------------------
                    // Purchase Price
                    //---------------------------------------------------

                    product.PurchasePrice = purchase.PurchasePrice;

                    await _productRepository.UpdateAsync(product);

                    //---------------------------------------------------
                    // Stock Transaction
                    //---------------------------------------------------

                    await _stockTransactionService.AddTransactionAsync(
                        productId: product.Id,
                        transactionType: TransactionType.PurchaseUpdate,
                        quantity: purchase.Quantity,
                        previousStock: previousStock,
                        currentStock: product.CurrentStock,
                        referenceNo: purchase.PurchaseNo,
                        remarks:
                            $"Purchase Updated (Old Qty : {dbPurchase.Quantity}, New Qty : {purchase.Quantity})",
                        referenceType: "Purchase");
                }

                //-------------------------------------------------------
                // PRODUCT CHANGED
                //-------------------------------------------------------

                else
                {
                    //---------------------------------------------------
                    // OLD PRODUCT
                    //---------------------------------------------------

                    var oldProduct = await _productRepository
                        .GetByIdAsync(dbPurchase.ProductId);

                    if (oldProduct == null)
                        throw new Exception("Old Product not found.");

                    int oldPreviousStock = oldProduct.CurrentStock;

                    //oldProduct.CurrentStock -= dbPurchase.Quantity;
                    DecreaseStock(oldProduct, dbPurchase.Quantity);

                    await _productRepository.UpdateAsync(oldProduct);

                    //---------------------------------------------------
                    // Refresh Old Product Purchase Price
                    //---------------------------------------------------

                    await UpdateProductPurchasePriceAsync(oldProduct.Id);

                    //---------------------------------------------------
                    // Transaction
                    //---------------------------------------------------

                    await _stockTransactionService.AddTransactionAsync(
                        productId: oldProduct.Id,
                        transactionType: TransactionType.PurchaseDelete,
                        quantity: dbPurchase.Quantity,
                        previousStock: oldPreviousStock,
                        currentStock: oldProduct.CurrentStock,
                        referenceNo: dbPurchase.PurchaseNo,
                        remarks: "Purchase moved to another product",
                        referenceType: "Purchase");

                    //---------------------------------------------------
                    // NEW PRODUCT
                    //---------------------------------------------------

                    var newProduct = await _productRepository
                        .GetByIdAsync(purchase.ProductId);

                    if (newProduct == null)
                        throw new Exception("New Product not found.");

                    int newPreviousStock = newProduct.CurrentStock;

                    //newProduct.CurrentStock += purchase.Quantity;
                    IncreaseStock(newProduct, purchase.Quantity);

                    newProduct.PurchasePrice = purchase.PurchasePrice;

                    await _productRepository.UpdateAsync(newProduct);

                    await _stockTransactionService.AddTransactionAsync(
                        productId: newProduct.Id,
                        transactionType: TransactionType.PurchaseUpdate,
                        quantity: purchase.Quantity,
                        previousStock: newPreviousStock,
                        currentStock: newProduct.CurrentStock,
                        referenceNo: purchase.PurchaseNo,
                        remarks: "Purchase moved from another product",
                        referenceType: "Purchase");
                }

                //-------------------------------------------------------
                // UPDATE PURCHASE RECORD
                //-------------------------------------------------------

                dbPurchase.PurchaseNo = purchase.PurchaseNo;
                dbPurchase.PurchaseDate = purchase.PurchaseDate;
                dbPurchase.ProductId = purchase.ProductId;
                dbPurchase.PurchasePrice = purchase.PurchasePrice;
                dbPurchase.Quantity = purchase.Quantity;
                dbPurchase.RemainingQuantity = purchase.Quantity;
                dbPurchase.TotalAmount = purchase.TotalAmount;
                dbPurchase.Remarks = purchase.Remarks;
                dbPurchase.UpdatedDate = DateTime.Now;

                await _purchaseRepository.UpdateAsync(dbPurchase);

                //-------------------------------------------------------
                // Refresh Purchase Price
                //-------------------------------------------------------

                await UpdateProductPurchasePriceAsync(dbPurchase.ProductId);

                //-------------------------------------------------------
                // Save
                //-------------------------------------------------------

                await _context.SaveChangesAsync();

                //-------------------------------------------------------
                // Commit
                //-------------------------------------------------------

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        //public async Task UpdatePurchaseAsync(PurchaseEntiity purchase)
        //{
        //    //var oldPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);
        //    var oldPurchase = await _purchaseRepository.GetByIdAsNoTrackingAsync(purchase.Id);

        //    if (oldPurchase == null)
        //        throw new Exception("Purchase not found.");

        //    if (oldPurchase.RemainingQuantity != oldPurchase.Quantity)
        //    {
        //        throw new Exception("This purchase is already used in Sale. Update not allowed.");
        //    }
        //    // ===========================
        //    // Same Product
        //    // ===========================
        //    if (oldPurchase.ProductId == purchase.ProductId)
        //    {
        //        var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //        if (product == null)
        //            throw new Exception("Product not found.");

        //        int previousStock = product.CurrentStock;

        //        // Reverse old quantity
        //        product.CurrentStock -= oldPurchase.Quantity;

        //        // Add new quantity
        //        product.CurrentStock += purchase.Quantity;

        //        await _productRepository.UpdateAsync(product);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: product.Id,
        //            transactionType: TransactionType.PurchaseUpdate,
        //            quantity: purchase.Quantity,
        //            previousStock: previousStock,
        //            currentStock: product.CurrentStock,
        //            referenceNo: purchase.PurchaseNo,
        //            remarks: $"Purchase Updated (Old Qty: {oldPurchase.Quantity}, New Qty: {purchase.Quantity})",
        //            referenceType: "Purchase"
        //        );
        //    }
        //    // ===========================
        //    // Product Changed
        //    // ===========================
        //    else
        //    {
        //        // Old Product
        //        var oldProduct = await _productRepository.GetByIdAsync(oldPurchase.ProductId);

        //        if (oldProduct == null)
        //            throw new Exception("Old Product not found.");

        //        int oldPreviousStock = oldProduct.CurrentStock;

        //        oldProduct.CurrentStock -= oldPurchase.Quantity;

        //        await _productRepository.UpdateAsync(oldProduct);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: oldProduct.Id,
        //            transactionType: TransactionType.PurchaseDelete,
        //            quantity: oldPurchase.Quantity,
        //            previousStock: oldPreviousStock,
        //            currentStock: oldProduct.CurrentStock,
        //            referenceNo: oldPurchase.PurchaseNo,
        //            remarks: "Purchase moved to another product",
        //            referenceType: "Purchase"
        //        );

        //        // New Product
        //        var newProduct = await _productRepository.GetByIdAsync(purchase.ProductId);

        //        if (newProduct == null)
        //            throw new Exception("New Product not found.");

        //        int newPreviousStock = newProduct.CurrentStock;

        //        newProduct.CurrentStock += purchase.Quantity;

        //        await _productRepository.UpdateAsync(newProduct);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: newProduct.Id,
        //            transactionType: TransactionType.PurchaseUpdate,
        //            quantity: purchase.Quantity,
        //            previousStock: newPreviousStock,
        //            currentStock: newProduct.CurrentStock,
        //            referenceNo: purchase.PurchaseNo,
        //            remarks: "Purchase moved from another product",
        //            referenceType: "Purchase"
        //        );
        //    }

        //    // Update Purchase Record
        //    //await _purchaseRepository.UpdateAsync(purchase);
        //    var dbPurchase = await _purchaseRepository.GetByIdAsync(purchase.Id);

        //    if (dbPurchase == null)
        //        throw new Exception("Purchase not found.");

        //    dbPurchase.PurchaseNo = purchase.PurchaseNo;
        //    dbPurchase.PurchaseDate = purchase.PurchaseDate;
        //    dbPurchase.ProductId = purchase.ProductId;
        //    dbPurchase.PurchasePrice = purchase.PurchasePrice;
        //    dbPurchase.Quantity = purchase.Quantity;

        //    dbPurchase.RemainingQuantity = purchase.Quantity;

        //    dbPurchase.TotalAmount = purchase.TotalAmount;
        //    dbPurchase.Remarks = purchase.Remarks;

        //    dbPurchase.UpdatedDate = DateTime.Now;

        //    await _purchaseRepository.UpdateAsync(dbPurchase);

        //    await _purchaseRepository.SaveAsync();

        //}

        //public async Task DeletePurchaseAsync(int id)
        //{
        //    var purchase = await _purchaseRepository.GetByIdAsync(id);

        //    if (purchase == null)
        //        throw new Exception("Purchase not found.");

        //    // Purchase already used in Sale
        //    if (purchase.RemainingQuantity != purchase.Quantity)
        //        throw new Exception("This purchase is already used in Sale. Delete not allowed.");

        //    var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //    if (product == null)
        //        throw new Exception("Product not found.");

        //    int previousStock = product.CurrentStock;

        //    // Reduce product stock
        //    product.CurrentStock -= purchase.Quantity;

        //    await _productRepository.UpdateAsync(product);

        //    // Stock Transaction
        //    await _stockTransactionService.AddTransactionAsync(
        //        productId: product.Id,
        //        transactionType: TransactionType.PurchaseDelete,
        //        quantity: purchase.Quantity,
        //        previousStock: previousStock,
        //        currentStock: product.CurrentStock,
        //        referenceNo: purchase.PurchaseNo,
        //        remarks: $"Purchase Deleted (Qty: {purchase.Quantity})",
        //        referenceType: "Purchase"
        //    );

        //    // Delete Purchase
        //    await _purchaseRepository.DeleteAsync(purchase);

        //    // Save Changes
        //    await _purchaseRepository.SaveAsync();
        //}

        public async Task DeletePurchaseAsync(int purchaseId)
        {
            await using var transaction =
                await _context.Database.BeginTransactionAsync();

            try
            {
                //-------------------------------------------------------
                // Existing Purchase
                //-------------------------------------------------------

                var purchase = await _purchaseRepository
                    .GetByIdAsync(purchaseId);

                if (purchase == null)
                    throw new Exception("Purchase not found.");

                //-------------------------------------------------------
                // Purchase Already Used?
                //-------------------------------------------------------

                if (purchase.RemainingQuantity != purchase.Quantity)
                    throw new Exception(
                        "This purchase has already been used in Sale. Delete not allowed.");

                //-------------------------------------------------------
                // Product
                //-------------------------------------------------------

                var product = await _productRepository
                    .GetByIdAsync(purchase.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                int previousStock = product.CurrentStock;

                //-------------------------------------------------------
                // Restore Product Stock
                //-------------------------------------------------------

                //product.CurrentStock -= purchase.Quantity;
                DecreaseStock(product, purchase.Quantity);

                //if (product.CurrentStock < 0)
                //    throw new Exception("Invalid stock calculation.");

                await _productRepository.UpdateAsync(product);

                //-------------------------------------------------------
                // Delete Purchase
                //-------------------------------------------------------

                await _purchaseRepository.DeleteAsync(purchase);

                //-------------------------------------------------------
                // Refresh Purchase Price
                //-------------------------------------------------------

                await UpdateProductPurchasePriceAsync(product.Id);

                //-------------------------------------------------------
                // Stock Transaction
                //-------------------------------------------------------

                await _stockTransactionService.AddTransactionAsync(
                    productId: product.Id,
                    transactionType: TransactionType.PurchaseDelete,
                    quantity: purchase.Quantity,
                    previousStock: previousStock,
                    currentStock: product.CurrentStock,
                    referenceNo: purchase.PurchaseNo,
                    remarks: $"Purchase Deleted (Qty : {purchase.Quantity})",
                    referenceType: "Purchase");

                //-------------------------------------------------------
                // Save
                //-------------------------------------------------------

                await _context.SaveChangesAsync();

                //-------------------------------------------------------
                // Commit
                //-------------------------------------------------------

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        //public async Task DeletePurchaseAsync(int id)
        //{
        //    var purchase = await _purchaseRepository.GetByIdAsync(id);

        //    if (purchase == null)
        //        return;

        //    if (purchase.RemainingQuantity != purchase.Quantity)
        //    {
        //        throw new Exception("This purchase is already used in Sale. Delete not allowed.");
        //    }
        //    var product = await _productRepository.GetByIdAsync(purchase.ProductId);

        //    if (product == null)
        //        throw new Exception("Product not found.");

        //    int previousStock = product.CurrentStock;

        //    // Purchase delete hone par stock kam hoga
        //    product.CurrentStock -= purchase.Quantity;

        //    await _productRepository.UpdateAsync(product);

        //    // Stock Transaction Entry
        //    await _stockTransactionService.AddTransactionAsync(
        //        productId: product.Id,
        //        transactionType: TransactionType.PurchaseDelete,
        //        quantity: purchase.Quantity,
        //        previousStock: previousStock,
        //        currentStock: product.CurrentStock,
        //        referenceNo: purchase.PurchaseNo,
        //        remarks: $"Purchase Deleted (Qty: {purchase.Quantity})",
        //        referenceType: "Purchase"
        //    );

        //    // Purchase Delete
        //    await _purchaseRepository.DeleteAsync(purchase);

        //    // Database Save
        //    await _purchaseRepository.SaveAsync();
        //}

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

        //private async Task UpdateProductPurchasePriceAsync(int productId)
        //{
        //    var product = await _productRepository.GetByIdAsync(productId);

        //    if (product == null)
        //        throw new Exception("Product not found.");

        //    var latestPurchase = await _purchaseRepository
        //        .GetLatestPurchaseByProductAsync(productId);

        //    product.PurchasePrice = latestPurchase?.PurchasePrice ?? 0;

        //    await _productRepository.UpdateAsync(product);
        //}
        private async Task UpdateProductPurchasePriceAsync(int productId)
        {
            var product = await _productRepository
                .GetByIdAsync(productId);

            if (product == null)
                throw new Exception("Product not found.");

            var latestPurchase = await _purchaseRepository
                .GetLatestPurchaseByProductAsync(productId);

            if (latestPurchase == null)
            {
                product.PurchasePrice = 0;
            }
            else
            {
                product.PurchasePrice = latestPurchase.PurchasePrice;
            }

            await _productRepository.UpdateAsync(product);
        }

        private void IncreaseStock(Product product, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            product.CurrentStock += quantity;
        }

        private void DecreaseStock(Product product, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (product.CurrentStock < quantity)
                throw new InvalidOperationException("Insufficient stock.");

            product.CurrentStock -= quantity;
        }
    }
}
