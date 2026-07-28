using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.StockTransactionServices;
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
        private readonly IStockTransactionService _stockTransactionService;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly ApplicationDbContext _context;
        private readonly ISalePurchaseDetailRepository _salePurchaseDetailRepository;
        public SaleService(
            ISaleRepository saleRepository,
            IProductRepository productRepository,
            IStockTransactionService stockTransactionService,
            IPurchaseRepository purchaseRepository,
            ISalePurchaseDetailRepository salePurchaseDetailRepository,
            ApplicationDbContext context)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
            _stockTransactionService = stockTransactionService;
            _purchaseRepository = purchaseRepository;
            _salePurchaseDetailRepository = salePurchaseDetailRepository;
            _context = context;
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
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Product

                var product = await _productRepository.GetByIdAsync(sale.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                if (product.CurrentStock < sale.Quantity)
                    throw new Exception("Insufficient stock.");

                // FIFO Allocation

                var details = await AllocatePurchaseFIFOAsync(
                    sale.ProductId,
                    sale.Quantity);

                int previousStock = product.CurrentStock;

                //product.CurrentStock -= sale.Quantity;
                DecreaseStock(product, sale.Quantity);

                if (sale.CreatedDate == default)
                    sale.CreatedDate = DateTime.Now;

                //-------------------------------------------------------
                // Save Sale First
                //-------------------------------------------------------

                await _saleRepository.AddAsync(sale);

                await _context.SaveChangesAsync();

                //-------------------------------------------------------
                // SaleId available now
                //-------------------------------------------------------

                foreach (var detail in details)
                {
                    detail.SaleId = sale.Id;
                }

                await _salePurchaseDetailRepository.AddRangeAsync(details);

                //-------------------------------------------------------
                // Update Product
                //-------------------------------------------------------

                await _productRepository.UpdateAsync(product);

                //-------------------------------------------------------
                // Stock Transaction
                //-------------------------------------------------------

                await _stockTransactionService.AddTransactionAsync(
                    productId: product.Id,
                    transactionType: TransactionType.Sale,
                    quantity: sale.Quantity,
                    previousStock: previousStock,
                    currentStock: product.CurrentStock,
                    referenceNo: sale.SaleNo,
                    remarks: sale.Remarks,
                    referenceType: "Sale");

                //-------------------------------------------------------
                // Save Everything
                //-------------------------------------------------------

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();

                _context.ChangeTracker.Clear();
                throw;
            }
        }

        //    public async Task AddSaleAsync(Sale sale)
        //    {
        //        var product = await _productRepository.GetByIdAsync(sale.ProductId);

        //        if (product == null)
        //            throw new Exception("Product not found.");

        //        if (product.CurrentStock < sale.Quantity)
        //            throw new Exception("Insufficient stock.");

        //        int previousStock = product.CurrentStock;

        //        product.CurrentStock -= sale.Quantity;

        //        await _productRepository.UpdateAsync(product);

        //        var purchase = await _purchaseRepository
        //.GetOldestAvailablePurchaseAsync(sale.ProductId);

        //        if (purchase == null)
        //            throw new Exception("Purchase not found.");

        //        if (purchase.RemainingQuantity < sale.Quantity)
        //            throw new Exception("Remaining quantity not available.");

        //        purchase.RemainingQuantity -= sale.Quantity;

        //        sale.PurchaseId = purchase.Id;

        //        // FIX 2: Explicitly ensure CreatedDate is set if not already set
        //        if (sale.CreatedDate == default)
        //        {
        //            sale.CreatedDate = DateTime.Now;
        //        }

        //        await _saleRepository.AddAsync(sale);

        //        await _stockTransactionService.AddTransactionAsync(
        //            productId: product.Id,
        //            transactionType: TransactionType.Sale,
        //            quantity: sale.Quantity,
        //            previousStock: previousStock,
        //            currentStock: product.CurrentStock,
        //            referenceNo: sale.SaleNo,
        //            remarks: sale.Remarks,
        //            referenceType: "Sale"
        //        );
        //    }

        //public async Task UpdateSaleAsync(Sale sale)
        //{
        //    var oldSale = await _saleRepository.GetByIdAsync(sale.Id);

        //    if (oldSale == null)
        //        throw new Exception("Sale not found.");

        //    // Same Product
        //    if (oldSale.ProductId == sale.ProductId)
        //    {
        //        var product = await _productRepository.GetByIdAsync(sale.ProductId);

        //        if (product == null)
        //            throw new Exception("Product not found.");

        //        // Restore previous stock
        //        product.CurrentStock += oldSale.Quantity;

        //        // Check stock
        //        if (product.CurrentStock < sale.Quantity)
        //            throw new Exception("Insufficient stock.");

        //        // Deduct new quantity
        //        product.CurrentStock -= sale.Quantity;

        //        await _productRepository.UpdateAsync(product);
        //    }
        //    else
        //    {
        //        // Restore old product stock
        //        var oldProduct = await _productRepository.GetByIdAsync(oldSale.ProductId);

        //        if (oldProduct != null)
        //        {
        //            oldProduct.CurrentStock += oldSale.Quantity;
        //            await _productRepository.UpdateAsync(oldProduct);
        //        }

        //        // Deduct from new product
        //        var newProduct = await _productRepository.GetByIdAsync(sale.ProductId);

        //        if (newProduct == null)
        //            throw new Exception("Product not found.");

        //        if (newProduct.CurrentStock < sale.Quantity)
        //            throw new Exception("Insufficient stock.");

        //        newProduct.CurrentStock -= sale.Quantity;

        //        await _productRepository.UpdateAsync(newProduct);
        //    }

        //    await _saleRepository.UpdateAsync(sale);
        //}

        //        public async Task UpdateSaleAsync(Sale sale)
        //        {
        //            var oldSale = await _saleRepository.GetByIdAsNoTrackingAsync(sale.Id);

        //            if (oldSale == null)
        //                throw new Exception("Sale not found.");

        //            // ==========================================
        //            // SAME PRODUCT
        //            // ==========================================
        //            if (oldSale.ProductId == sale.ProductId)
        //            {
        //                var product = await _productRepository.GetByIdAsync(sale.ProductId);

        //                if (product == null)
        //                    throw new Exception("Product not found.");

        //                int previousStock = product.CurrentStock;

        //                // Reverse old sale
        //                product.CurrentStock += oldSale.Quantity;

        //                // Check stock
        //                if (product.CurrentStock < sale.Quantity)
        //                    throw new Exception("Insufficient stock.");

        //                // Apply new sale
        //                product.CurrentStock -= sale.Quantity;
        ////                MessageBox.Show(
        ////$@"Before={previousStock}
        ////Old={oldSale.Quantity}
        ////New={sale.Quantity}
        ////AfterReverse={previousStock + oldSale.Quantity}
        ////Final={product.CurrentStock}");
        //                await _productRepository.UpdateAsync(product);

        //                //            var purchase = await _purchaseRepository
        //                //.GetOldestAvailablePurchaseAsync(sale.ProductId);

        //                var purchase = await _purchaseRepository
        //    .GetByIdAsync(oldSale.PurchaseId);

        //                if (purchase == null)
        //                    throw new Exception("Purchase not found.");

        //                purchase.RemainingQuantity += oldSale.Quantity;
        //                //if (purchase != null)
        //                //{
        //                //    purchase.RemainingQuantity += sale.Quantity;
        //                //}

        //                if (purchase.RemainingQuantity < sale.Quantity)
        //                    throw new Exception("Remaining quantity not available.");

        //                purchase.RemainingQuantity -= sale.Quantity;


        //                sale.PurchaseId = purchase.Id;

        //                await _stockTransactionService.AddTransactionAsync(
        //                    productId: product.Id,
        //                    transactionType: TransactionType.SaleUpdate,
        //                    quantity: sale.Quantity,
        //                    previousStock: previousStock,
        //                    currentStock: product.CurrentStock,
        //                    referenceNo: sale.SaleNo,
        //                    remarks: $"Sale Updated (Old Qty: {oldSale.Quantity}, New Qty: {sale.Quantity})",
        //                    referenceType: "Sale"
        //                );
        //            }
        //            // ==========================================
        //            // PRODUCT CHANGED
        //            // ==========================================
        //            else
        //            {
        //                // Restore Old Product
        //                var oldProduct = await _productRepository.GetByIdAsync(oldSale.ProductId);

        //                if (oldProduct == null)
        //                    throw new Exception("Old product not found.");

        //                int oldPreviousStock = oldProduct.CurrentStock;

        //                oldProduct.CurrentStock += oldSale.Quantity;

        //                await _productRepository.UpdateAsync(oldProduct);

        //                // Restore old purchase remaining quantity
        //                var oldPurchase = await _purchaseRepository.GetByIdAsync(oldSale.PurchaseId);

        //                if (oldPurchase == null)
        //                    throw new Exception("Old purchase not found.");

        //                oldPurchase.RemainingQuantity += oldSale.Quantity;

        //                await _stockTransactionService.AddTransactionAsync(
        //                    productId: oldProduct.Id,
        //                    transactionType: TransactionType.SaleDelete,
        //                    quantity: oldSale.Quantity,
        //                    previousStock: oldPreviousStock,
        //                    currentStock: oldProduct.CurrentStock,
        //                    referenceNo: oldSale.SaleNo,
        //                    remarks: "Sale moved to another product",
        //                    referenceType: "Sale"
        //                );

        //                // Deduct New Product
        //                var newProduct = await _productRepository.GetByIdAsync(sale.ProductId);

        //                if (newProduct == null)
        //                    throw new Exception("New product not found.");

        //                if (newProduct.CurrentStock < sale.Quantity)
        //                    throw new Exception("Insufficient stock.");

        //                int newPreviousStock = newProduct.CurrentStock;

        //                newProduct.CurrentStock -= sale.Quantity;

        //                await _productRepository.UpdateAsync(newProduct);

        //                var newPurchase = await _purchaseRepository
        //    .GetOldestAvailablePurchaseAsync(sale.ProductId);

        //                if (newPurchase == null)
        //                    throw new Exception("Purchase not found.");

        //                if (newPurchase.RemainingQuantity < sale.Quantity)
        //                    throw new Exception("Remaining quantity not available.");

        //                newPurchase.RemainingQuantity -= sale.Quantity;

        //                sale.PurchaseId = newPurchase.Id;

        //                await _stockTransactionService.AddTransactionAsync(
        //                    productId: newProduct.Id,
        //                    transactionType: TransactionType.SaleUpdate,
        //                    quantity: sale.Quantity,
        //                    previousStock: newPreviousStock,
        //                    currentStock: newProduct.CurrentStock,
        //                    referenceNo: sale.SaleNo,
        //                    remarks: "Sale moved from another product",
        //                    referenceType: "Sale"
        //                );
        //            }

        //            // ==========================================
        //            // UPDATE SALE RECORD
        //            // ==========================================
        //            var dbSale = await _saleRepository.GetByIdAsync(sale.Id);

        //            if (dbSale == null)
        //                throw new Exception("Sale not found.");

        //            dbSale.SaleNo = sale.SaleNo;
        //            dbSale.SaleDate = sale.SaleDate;
        //            dbSale.ProductId = sale.ProductId;
        //            dbSale.SalePrice = sale.SalePrice;
        //            dbSale.Quantity = sale.Quantity;
        //            dbSale.TotalAmount = sale.TotalAmount;
        //            dbSale.Remarks = sale.Remarks;
        //            dbSale.PurchaseId = sale.PurchaseId;

        //            dbSale.UpdatedDate =  DateTime.Now;

        //            await _saleRepository.UpdateAsync(dbSale);

        //            await _saleRepository.SaveAsync();
        //        }

        public async Task UpdateSaleAsync(Sale sale)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var existingSale = await _saleRepository.GetByIdAsync(sale.Id);

                if (existingSale == null)
                    throw new Exception("Sale not found.");

                // ===========================
                // SAME PRODUCT
                // ===========================
                if (existingSale.ProductId == sale.ProductId)
                {
                    var product = await _productRepository.GetByIdAsync(existingSale.ProductId);

                    if (product == null)
                        throw new Exception("Product not found.");

                    await RestorePurchaseFIFOAsync(existingSale.Id);
                    await DeleteSalePurchaseDetailsAsync(existingSale.Id);

                    //product.CurrentStock += existingSale.Quantity;

                    IncreaseStock(product, existingSale.Quantity);

                    if (product.CurrentStock < sale.Quantity)
                        throw new Exception("Insufficient stock.");

                    var details = await AllocatePurchaseFIFOAsync(
                        sale.ProductId,
                        sale.Quantity);

                    int previousStock = product.CurrentStock;

                    //product.CurrentStock -= sale.Quantity;
                    DecreaseStock(product, sale.Quantity);


                    existingSale.SaleDate = sale.SaleDate;
                    existingSale.ProductId = sale.ProductId;
                    existingSale.Quantity = sale.Quantity;
                    existingSale.SalePrice = sale.SalePrice;
                    existingSale.TotalAmount = sale.TotalAmount;
                    existingSale.Remarks = sale.Remarks;
                    existingSale.UpdatedDate = DateTime.Now;

                    await _productRepository.UpdateAsync(product);
                    await _saleRepository.UpdateAsync(existingSale);

                    await _context.SaveChangesAsync();

                    foreach (var item in details)
                        item.SaleId = existingSale.Id;

                    await _salePurchaseDetailRepository.AddRangeAsync(details);

                    await _stockTransactionService.AddTransactionAsync(
                        product.Id,
                        TransactionType.SaleUpdate,
                        sale.Quantity,
                        previousStock,
                        product.CurrentStock,
                        sale.SaleNo,
                        "Sale Updated",
                        "Sale");
                }
                // ===========================
                // PRODUCT CHANGED
                // ===========================
                else
                {
                    var oldProduct = await _productRepository.GetByIdAsync(existingSale.ProductId);
                    if (oldProduct == null)
                        throw new Exception("Old product not found.");

                    var newProduct = await _productRepository.GetByIdAsync(sale.ProductId);
                    if (newProduct == null)
                        throw new Exception("New product not found.");

                    await RestorePurchaseFIFOAsync(existingSale.Id);
                    await DeleteSalePurchaseDetailsAsync(existingSale.Id);

                    int oldPreviousStock = oldProduct.CurrentStock;

                    //oldProduct.CurrentStock += existingSale.Quantity;
                    IncreaseStock(oldProduct, existingSale.Quantity);

                    if (newProduct.CurrentStock < sale.Quantity)
                        throw new Exception("Insufficient stock.");

                    int newPreviousStock = newProduct.CurrentStock;

                    var details = await AllocatePurchaseFIFOAsync(
                        sale.ProductId,
                        sale.Quantity);

                    //newProduct.CurrentStock -= sale.Quantity;
                    DecreaseStock(newProduct, sale.Quantity);

                    existingSale.SaleDate = sale.SaleDate;
                    existingSale.ProductId = sale.ProductId;
                    existingSale.Quantity = sale.Quantity;
                    existingSale.SalePrice = sale.SalePrice;
                    existingSale.TotalAmount = sale.TotalAmount;
                    existingSale.Remarks = sale.Remarks;
                    existingSale.UpdatedDate = DateTime.Now;

                    await _productRepository.UpdateAsync(oldProduct);
                    await _productRepository.UpdateAsync(newProduct);
                    await _saleRepository.UpdateAsync(existingSale);

                    await _context.SaveChangesAsync();

                    foreach (var item in details)
                        item.SaleId = existingSale.Id;

                    await _salePurchaseDetailRepository.AddRangeAsync(details);

                    await _stockTransactionService.AddTransactionAsync(
                        oldProduct.Id,
                        TransactionType.SaleDelete,
                        existingSale.Quantity,
                        oldPreviousStock,
                        oldProduct.CurrentStock,
                        existingSale.SaleNo,
                        "Sale moved from old product",
                        "Sale");

                    await _stockTransactionService.AddTransactionAsync(
                        newProduct.Id,
                        TransactionType.SaleUpdate,
                        sale.Quantity,
                        newPreviousStock,
                        newProduct.CurrentStock,
                        sale.SaleNo,
                        "Sale moved to new product",
                        "Sale");
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();

                _context.ChangeTracker.Clear();

                throw;
            }
        }

        //public async Task DeleteSaleAsync(int id)
        //{
        //    var sale = await _saleRepository.GetByIdAsync(id);

        //    if (sale == null)
        //        throw new Exception("Sale not found.");

        //    var product = await _productRepository.GetByIdAsync(sale.ProductId);

        //    if (product == null)
        //        throw new Exception("Product not found.");

        //    int previousStock = product.CurrentStock;

        //    // Restore Stock
        //    product.CurrentStock += sale.Quantity;

        //    //        var purchase = await _purchaseRepository
        //    //.GetOldestAvailablePurchaseAsync(sale.ProductId);
        //    var purchase = await _purchaseRepository.GetByIdAsync(sale.PurchaseId);
        //    if (purchase == null)
        //        throw new Exception("Purchase not found.");

        //    purchase.RemainingQuantity += sale.Quantity;
        //    //if (purchase != null)
        //    //{
        //    //    purchase.RemainingQuantity += sale.Quantity;
        //    //}

        //    await _productRepository.UpdateAsync(product);

        //    // Stock Transaction
        //    await _stockTransactionService.AddTransactionAsync(
        //        productId: product.Id,
        //        transactionType: TransactionType.SaleDelete,
        //        quantity: sale.Quantity,
        //        previousStock: previousStock,
        //        currentStock: product.CurrentStock,
        //        referenceNo: sale.SaleNo,
        //        remarks: $"Sale Deleted (Qty: {sale.Quantity})",
        //        referenceType: "Sale"
        //    );

        //    // Delete Sale
        //    await _saleRepository.DeleteAsync(sale);

        //    // Save Changes
        //    await _saleRepository.SaveAsync();
        //}

        public async Task DeleteSaleAsync(int saleId)
        {
            await using var transaction =
                await _context.Database.BeginTransactionAsync();

            try
            {
                //--------------------------------------------------
                // Existing Sale
                //--------------------------------------------------

                var sale = await _saleRepository.GetByIdAsync(saleId);

                if (sale == null)
                    throw new Exception("Sale not found.");

                //--------------------------------------------------
                // Product
                //--------------------------------------------------

                var product = await _productRepository
                    .GetByIdAsync(sale.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                int previousStock = product.CurrentStock;

                //--------------------------------------------------
                // Restore Purchase FIFO
                //--------------------------------------------------

                await RestorePurchaseFIFOAsync(sale.Id);

                //--------------------------------------------------
                // Restore Product Stock
                //--------------------------------------------------

                //product.CurrentStock += sale.Quantity;
                IncreaseStock(product, sale.Quantity);

                //--------------------------------------------------
                // Delete SalePurchaseDetails
                //--------------------------------------------------

                await DeleteSalePurchaseDetailsAsync(sale.Id);

                //--------------------------------------------------
                // Delete Sale
                //--------------------------------------------------

                await _saleRepository.DeleteAsync(sale);

                //--------------------------------------------------
                // Update Product
                //--------------------------------------------------

                await _productRepository.UpdateAsync(product);

                //--------------------------------------------------
                // Stock Transaction
                //--------------------------------------------------

                await _stockTransactionService.AddTransactionAsync(
                    productId: product.Id,
                    transactionType: TransactionType.Sale,
                    quantity: sale.Quantity,
                    previousStock: previousStock,
                    currentStock: product.CurrentStock,
                    referenceNo: sale.SaleNo,
                    remarks: "Sale Deleted",
                    referenceType: "Sale Delete");

                //--------------------------------------------------
                // Save
                //--------------------------------------------------

                await _context.SaveChangesAsync();

                //--------------------------------------------------
                // Commit
                //--------------------------------------------------

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();

                _context.ChangeTracker.Clear();

                throw;
            }
        }

        public async Task<List<Sale>> SearchSalesAsync(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return await _saleRepository.GetAllAsync();

            return await _saleRepository.SearchSalesAsync(keyword);
        }

        private async Task<List<SalePurchaseDetail>> AllocatePurchaseFIFOAsync(
    int productId,
    int saleQuantity)
        {
            var purchases = await _purchaseRepository
                .GetAvailablePurchasesAsync(productId);

            if (!purchases.Any())
                throw new Exception("No purchase batches available.");

            int remainingQty = saleQuantity;

            List<SalePurchaseDetail> details = new();

            foreach (var purchase in purchases)
            {
                if (remainingQty <= 0)
                    break;

                if (purchase.RemainingQuantity <= 0)
                    continue;

                int consumeQty = Math.Min(
                    purchase.RemainingQuantity,
                    remainingQty);

                //purchase.RemainingQuantity -= consumeQty;
                ConsumePurchase(purchase, consumeQty);

                remainingQty -= consumeQty;

                details.Add(new SalePurchaseDetail
                {
                    PurchaseId = purchase.Id,
                    Quantity = consumeQty,
                    PurchasePrice = purchase.PurchasePrice
                });
            }

            if (remainingQty > 0)
                throw new Exception("Insufficient purchase quantity available.");

            return details;
        }

        private async Task RestorePurchaseFIFOAsync(int saleId)
        {
            var details = await _salePurchaseDetailRepository
                .GetBySaleIdAsync(saleId);

            if (!details.Any())
                return;

            foreach (var detail in details)
            {
                var purchase = detail.Purchase;

                if (purchase == null)
                {
                    purchase = await _purchaseRepository
                        .GetByIdAsync(detail.PurchaseId);

                    if (purchase == null)
                        throw new Exception($"Purchase batch not found. PurchaseId = {detail.PurchaseId}");
                }

                purchase.RemainingQuantity += detail.Quantity;
            }
        }

        private async Task DeleteSalePurchaseDetailsAsync(int saleId)
        {
            var details = await _salePurchaseDetailRepository
                .GetBySaleIdAsync(saleId);

            if (!details.Any())
                return;

            await _salePurchaseDetailRepository
                .DeleteRangeAsync(details);
        }

        private void ConsumePurchase(PurchaseEntiity purchase, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (purchase.RemainingQuantity < quantity)
                throw new InvalidOperationException("Not enough remaining quantity.");

            purchase.RemainingQuantity -= quantity;
        }

        //private void IncreaseStock(Product product, int quantity)
        //{
        //    if (quantity <= 0)
        //        throw new ArgumentException("Quantity must be greater than zero.");

        //    product.CurrentStock += quantity;
        //}

        //private void DecreaseStock(Product product, int quantity)
        //{
        //    if (quantity <= 0)
        //        throw new ArgumentException("Quantity must be greater than zero.");

        //    if (product.CurrentStock < quantity)
        //        throw new InvalidOperationException("Insufficient stock.");

        //    product.CurrentStock -= quantity;
        //}

        private void IncreaseStock(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            checked
            {
                product.CurrentStock += quantity;
            }
        }

        private void DecreaseStock(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (product.CurrentStock < quantity)
                throw new InvalidOperationException("Insufficient stock.");

            product.CurrentStock -= quantity;
        }
    }
}
