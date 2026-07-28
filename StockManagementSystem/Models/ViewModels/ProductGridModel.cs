using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModels
{
    public class ProductGridModel
    {
        public int Id { get; set; }

        public string ProductCode { get; set; } = "";

        public string ProductName { get; set; } = "";

        public string? CategoryName { get; set; }

        public string? BrandName { get; set; }

        public string? UnitName { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public int CurrentStock { get; set; }

        public int MinimumStock { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? ImagePath { get; set; }
    }
}
