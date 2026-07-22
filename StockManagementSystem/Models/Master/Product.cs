using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class Product : BaseEntity
    {
        // Auto Generated
        public string ProductCode { get; set; } = string.Empty;

        // Basic Information
        public string ProductName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        // Category
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // Brand
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        // Unit
        public int UnitId { get; set; }
        public Unit Unit { get; set; } = null!;

        // Vehicle Compatibility
        public string? VehicleModel { get; set; }

        // Pricing
        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        // Current Available Quantity
        public int CurrentStock { get; set; } = 0;

        // Low Stock Alert Limit
        public int MinimumStock { get; set; } = 10;

        // Barcode (Optional)
        public string? Barcode { get; set; }

        // Active / Inactive
        public bool IsActive { get; set; } = true;
    }
}
