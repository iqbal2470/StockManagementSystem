using StockManagementSystem.Data;
using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.StockTransactionServices;
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
        private readonly IStockTransactionService _stockTransactionService;
        private readonly ApplicationDbContext _context;
        public ProductService(IProductRepository productRepository, IStockTransactionService stockTransactionService, ApplicationDbContext context)
        {
            _productRepository = productRepository;
            _stockTransactionService = stockTransactionService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        //public async Task AddProductAsync(Product product)
        //{
        //    await _productRepository.AddAsync(product);
        //    await _productRepository.SaveAsync();
        //}

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            await _productRepository.SaveAsync();

            //if (product.CurrentStock > 0)
            //{
            //    await _stockTransactionService.AddTransactionAsync(
            //        productId: product.Id,
            //        transactionType: TransactionType.OpeningStock,
            //        quantity: product.CurrentStock,
            //        previousStock: 0,
            //        currentStock: product.CurrentStock,
            //        referenceNo: product.ProductCode,
            //        remarks: "Opening Stock",
            //        referenceType: "Product"
            //    );
            //}

            await _stockTransactionService.AddTransactionAsync(
                productId: product.Id,
                transactionType: TransactionType.ProductCreate,   // Enum add karna hoga
                quantity: 0,
                previousStock: 0,
                currentStock: product.CurrentStock,
                referenceNo: product.ProductCode,
                remarks: "Product Created",
                referenceType: "Product");

            await _productRepository.SaveAsync();
        }

        //public async Task UpdateProductAsync(Product product)
        //{
        //    await _productRepository.UpdateAsync(product);
        //    await _productRepository.SaveAsync();
        //}

        //public async Task UpdateProductAsync(Product product)
        //{
        //    var oldProduct = await _productRepository.GetByIdAsync(product.Id);

        //    if (oldProduct == null)
        //        throw new Exception("Product not found.");

        //    // Opening Stock Changed
        //    //if (oldProduct.CurrentStock != product.CurrentStock)
        //    //{
        //    //    await _stockTransactionService.AddTransactionAsync(
        //    //        productId: product.Id,
        //    //        transactionType: TransactionType.ProductUpdate,
        //    //        quantity: Math.Abs(product.CurrentStock - oldProduct.CurrentStock),
        //    //        //quantity: product.CurrentStock,
        //    //        previousStock: oldProduct.CurrentStock,
        //    //        currentStock: product.CurrentStock,
        //    //        referenceNo: product.ProductCode,
        //    //        remarks: "Opening Stock Updated",
        //    //        referenceType: "Product"
        //    //    );
        //    //}
        //    oldProduct.ProductName = product.ProductName;
        //    oldProduct.ProductCode = product.ProductCode;
        //    oldProduct.Barcode = product.Barcode;
        //    oldProduct.BrandId = product.BrandId;
        //    oldProduct.CategoryId = product.CategoryId;
        //    oldProduct.UnitId = product.UnitId;
        //    oldProduct.VehicleModel = product.VehicleModel;
        //    oldProduct.PurchasePrice = product.PurchasePrice;
        //    oldProduct.SalePrice = product.SalePrice;
        //    //oldProduct.CurrentStock = product.CurrentStock;
        //    oldProduct.MinimumStock = product.MinimumStock;
        //    oldProduct.Description = product.Description;
        //    oldProduct.ImagePath = product.ImagePath;
        //    oldProduct.IsActive = product.IsActive;

        //    //oldProduct.ProductName = product.ProductName;
        //    //oldProduct.ProductCode = product.ProductCode;
        //    //oldProduct.Barcode = product.Barcode;
        //    //oldProduct.BrandId = product.BrandId;
        //    //oldProduct.CategoryId = product.CategoryId;
        //    //oldProduct.UnitId = product.UnitId;
        //    //oldProduct.PurchasePrice = product.PurchasePrice;
        //    //oldProduct.SalePrice = product.SalePrice;
        //    //oldProduct.CurrentStock = product.CurrentStock;
        //    //oldProduct.Description = product.Description;

        //    await _productRepository.UpdateAsync(oldProduct);
        //    await _productRepository.SaveAsync();
        //}

        public async Task UpdateProductAsync(Product product)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var oldProduct = await _productRepository.GetByIdAsync(product.Id);

                if (oldProduct == null)
                    throw new Exception("Product not found.");

                oldProduct.ProductName = product.ProductName;
                oldProduct.ProductCode = product.ProductCode;
                oldProduct.Barcode = product.Barcode;
                oldProduct.BrandId = product.BrandId;
                oldProduct.CategoryId = product.CategoryId;
                oldProduct.UnitId = product.UnitId;
                oldProduct.VehicleModel = product.VehicleModel;
                oldProduct.PurchasePrice = product.PurchasePrice;
                oldProduct.SalePrice = product.SalePrice;
                oldProduct.MinimumStock = product.MinimumStock;
                oldProduct.Description = product.Description;
                oldProduct.ImagePath = product.ImagePath;
                oldProduct.IsActive = product.IsActive;

                await _productRepository.UpdateAsync(oldProduct);

                // Agar future me ProductUpdate transaction log karna ho
                /*
                await _stockTransactionService.AddTransactionAsync(
                    productId: oldProduct.Id,
                    transactionType: TransactionType.ProductUpdate,
                    quantity: 0,
                    previousStock: oldProduct.CurrentStock,
                    currentStock: oldProduct.CurrentStock,
                    referenceNo: oldProduct.ProductCode,
                    remarks: "Product Updated",
                    referenceType: "Product");
                */

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }


        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
                throw new Exception("Product not found.");

            // Product Delete Transaction
            await _stockTransactionService.AddTransactionAsync(
                productId: product.Id,
                transactionType: TransactionType.ProductDelete,
                quantity: product.CurrentStock,
                previousStock: product.CurrentStock,
                currentStock: product.CurrentStock,
                referenceNo: product.ProductCode,
                remarks: "Product Deleted",
                referenceType: "Product"
            );

            // Soft Delete
            product.IsActive = false;

            await _productRepository.UpdateAsync(product);
            await _productRepository.SaveAsync();
        }

        //public async Task DeleteProductAsync(int id)
        //{
        //    var product = await _productRepository.GetByIdAsync(id);

        //    if (product != null)
        //    {
        //        await _productRepository.DeleteAsync(product);
        //        await _productRepository.SaveAsync();
        //    }
        //}

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


        public async Task<int> GetTotalProductsCountAsync()
        {
            return await _productRepository.GetTotalProductsCountAsync();
        }

        public async Task<int> GetInStockCountAsync()
        {
            return await _productRepository.GetInStockCountAsync();
        }

        public async Task<int> GetLowStockCountAsync()
        {
            return await _productRepository.GetLowStockCountAsync();
        }

        public async Task<int> GetOutOfStockCountAsync()
        {
            return await _productRepository.GetOutOfStockCountAsync();
        }


        public async Task<int> GetCurrentStockQuantityAsync()
        {
            return await _productRepository.GetCurrentStockQuantityAsync();
        }
    }
}
