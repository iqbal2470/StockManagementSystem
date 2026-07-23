using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Dashboard
{

    public class TopSellingProductModel
    {
       

        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string? ImagePath { get; set; }

        public int TotalQuantity { get; set; }

        public decimal TotalAmount { get; set; }

        public int Progress { get; set; }
    }
}
