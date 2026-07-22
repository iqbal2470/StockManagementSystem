using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Dashboard
{
    public class SalesChartModel
    {
        public string Month { get; set; } = string.Empty;

        public decimal TotalSales { get; set; }
    }
}
