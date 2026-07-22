using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Dashboard
{
    public class DashboardSummaryModel
    {
        public int TotalProducts { get; set; }

        public int TotalCategories { get; set; }

        public int TotalBrands { get; set; }

        public int TotalUnits { get; set; }

        public decimal TotalPurchaseAmount { get; set; }

        public decimal TotalSalesAmount { get; set; }

        public int CurrentStock { get; set; }

        public int LowStockProducts { get; set; }
    }

}
