using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModels
{
    public class ReportSummaryModel
    {
        public int TotalProducts { get; set; }

        public decimal TotalPurchase { get; set; }

        public decimal TotalSales { get; set; }

        public decimal Profit { get; set; }
    }
}
