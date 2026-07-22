using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Reports
{
    public class StockReportModel
    {
        public string ProductCode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public string Unit { get; set; } = string.Empty;

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public int CurrentStock { get; set; }

        public int MinimumStock { get; set; }

        public bool IsActive { get; set; }
    }
}
