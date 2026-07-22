using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Reports
{
    public class PurchaseReportModel
    {
        public string PurchaseNo { get; set; } = string.Empty;

        public DateTime PurchaseDate { get; set; }

        public string ProductCode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public decimal PurchasePrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
