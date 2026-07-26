using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModels
{
    public class ChartDataModel
    {
        public string Label { get; set; } = string.Empty;

        public decimal Value { get; set; }

        //public decimal SecondValue { get; set; }

        public decimal Profit { get; set; }

        public decimal Loss { get; set; }
    }
}
