using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Dashboard
{
    public class RecentSaleModel
    {
        public DateTime SaleDate { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
