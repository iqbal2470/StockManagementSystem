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

        public SaleService(
            ISaleRepository saleRepository,
            IProductRepository productRepository,
            IStockTransactionService stockTransactionService)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
            _stockTransactionService = stockTransactionService;
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

        //public async Task AddSaleAsync(Sale sale)
        //{
        //    var product = await _productRepository.GetByIdAsync(sale.ProductId);

        //    if (product == null)
        //        throw new Exception("Product not found.");

        //    if (product.CurrentStock < sale.Quantity)
        //        throw new Exception("Insufficient stock.");

        //    product.CurrentStock -= sale.Quantity;

        //    await _productRepository.UpdateAsync(product);

        //    await _saleRepository.AddAsync(sale);
        //}

        public async Task AddSaleAsync(Sale sale)
        {
            var product = await _productRepository.GetByIdAsync(sale.ProductId);

            if (product == null)
                throw new Exception("Product not found.");

            if (product.CurrentStock < sale.Quantity)
                throw new Exception("Insufficient stock.");

            int previousStock = product.CurrentStock;

            product.CurrentStock -= sale.Quantity;

            await _productRepository.UpdateAsync(product);

            // FIX 2: Explicitly ensure CreatedDate is set if not already set
            if (sale.CreatedDate == default)
            {
                sale.CreatedDate = DateTime.Now;
            }

            await _saleRepository.AddAsync(sale);

            await _stockTransactionService.AddTransactionAsync(
                productId: product.Id,
                transactionType: TransactionType.Sale,
                quantity: sale.Quantity,
                previousStock: previousStock,
                currentStock: product.CurrentStock,
                referenceNo: sale.SaleNo,
                remarks: sale.Remarks,
                referenceType: "Sale"
            );
        }

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

        public async Task UpdateSaleAsync(Sale sale)
        {
            var oldSale = await _saleRepository.GetByIdAsNoTrackingAsync(sale.Id);

            if (oldSale == null)
                throw new Exception("Sale not found.");

            // ==========================================
            // SAME PRODUCT
            // ==========================================
            if (oldSale.ProductId == sale.ProductId)
            {
                var product = await _productRepository.GetByIdAsync(sale.ProductId);

                if (product == null)
                    throw new Exception("Product not found.");

                int previousStock = product.CurrentStock;

                // Reverse old sale
                product.CurrentStock += oldSale.Quantity;

                // Check stock
                if (product.CurrentStock < sale.Quantity)
                    throw new Exception("Insufficient stock.");

                // Apply new sale
                product.CurrentStock -= sale.Quantity;
//                MessageBox.Show(
//$@"Before={previousStock}
//Old={oldSale.Quantity}
//New={sale.Quantity}
//AfterReverse={previousStock + oldSale.Quantity}
//Final={product.CurrentStock}");
                await _productRepository.UpdateAsync(product);

                await _stockTransactionService.AddTransactionAsync(
                    productId: product.Id,
                    transactionType: TransactionType.SaleUpdate,
                    quantity: sale.Quantity,
                    previousStock: previousStock,
                    currentStock: product.CurrentStock,
                    referenceNo: sale.SaleNo,
                    remarks: $"Sale Updated (Old Qty: {oldSale.Quantity}, New Qty: {sale.Quantity})",
                    referenceType: "Sale"
                );
            }
            // ==========================================
            // PRODUCT CHANGED
            // ==========================================
            else
            {
                // Restore Old Product
                var oldProduct = await _productRepository.GetByIdAsync(oldSale.ProductId);

                if (oldProduct == null)
                    throw new Exception("Old product not found.");

                int oldPreviousStock = oldProduct.CurrentStock;

                oldProduct.CurrentStock += oldSale.Quantity;

                await _productRepository.UpdateAsync(oldProduct);

                await _stockTransactionService.AddTransactionAsync(
                    productId: oldProduct.Id,
                    transactionType: TransactionType.SaleDelete,
                    quantity: oldSale.Quantity,
                    previousStock: oldPreviousStock,
                    currentStock: oldProduct.CurrentStock,
                    referenceNo: oldSale.SaleNo,
                    remarks: "Sale moved to another product",
                    referenceType: "Sale"
                );

                // Deduct New Product
                var newProduct = await _productRepository.GetByIdAsync(sale.ProductId);

                if (newProduct == null)
                    throw new Exception("New product not found.");

                if (newProduct.CurrentStock < sale.Quantity)
                    throw new Exception("Insufficient stock.");

                int newPreviousStock = newProduct.CurrentStock;

                newProduct.CurrentStock -= sale.Quantity;

                await _productRepository.UpdateAsync(newProduct);

                await _stockTransactionService.AddTransactionAsync(
                    productId: newProduct.Id,
                    transactionType: TransactionType.SaleUpdate,
                    quantity: sale.Quantity,
                    previousStock: newPreviousStock,
                    currentStock: newProduct.CurrentStock,
                    referenceNo: sale.SaleNo,
                    remarks: "Sale moved from another product",
                    referenceType: "Sale"
                );
            }

            // ==========================================
            // UPDATE SALE RECORD
            // ==========================================
            var dbSale = await _saleRepository.GetByIdAsync(sale.Id);

            if (dbSale == null)
                throw new Exception("Sale not found.");

            dbSale.SaleNo = sale.SaleNo;
            dbSale.SaleDate = sale.SaleDate;
            dbSale.ProductId = sale.ProductId;
            dbSale.SalePrice = sale.SalePrice;
            dbSale.Quantity = sale.Quantity;
            dbSale.TotalAmount = sale.TotalAmount;
            dbSale.Remarks = sale.Remarks;

            dbSale.UpdatedDate =  DateTime.Now;

            await _saleRepository.UpdateAsync(dbSale);

            await _saleRepository.SaveAsync();
        }

        public async Task DeleteSaleAsync(int id)
        {
            var sale = await _saleRepository.GetByIdAsync(id);

            if (sale == null)
                throw new Exception("Sale not found.");

            var product = await _productRepository.GetByIdAsync(sale.ProductId);

            if (product == null)
                throw new Exception("Product not found.");

            int previousStock = product.CurrentStock;

            // Restore Stock
            product.CurrentStock += sale.Quantity;

            await _productRepository.UpdateAsync(product);

            // Stock Transaction
            await _stockTransactionService.AddTransactionAsync(
                productId: product.Id,
                transactionType: TransactionType.SaleDelete,
                quantity: sale.Quantity,
                previousStock: previousStock,
                currentStock: product.CurrentStock,
                referenceNo: sale.SaleNo,
                remarks: $"Sale Deleted (Qty: {sale.Quantity})",
                referenceType: "Sale"
            );

            // Delete Sale
            await _saleRepository.DeleteAsync(sale);

            // Save Changes
            await _saleRepository.SaveAsync();
        }

        //public async Task DeleteSaleAsync(int id)
        //{
        //    var sale = await _saleRepository.GetByIdAsync(id);

        //    if (sale == null)
        //        throw new Exception("Sale not found.");

        //    var product = await _productRepository.GetByIdAsync(sale.ProductId);

        //    if (product != null)
        //    {
        //        product.CurrentStock += sale.Quantity;

        //        await _productRepository.UpdateAsync(product);
        //    }

        //    await _saleRepository.DeleteAsync(sale);
        //}

        public async Task<List<Sale>> SearchSalesAsync(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return await _saleRepository.GetAllAsync();

            return await _saleRepository.SearchSalesAsync(keyword);
        }
    }
}
