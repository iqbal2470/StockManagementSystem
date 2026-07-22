using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Dashboard
{

    public class TopSellingProductModel
    {
        public string ProductName { get; set; } = string.Empty;

        public int TotalQuantity { get; set; }
    }
}
