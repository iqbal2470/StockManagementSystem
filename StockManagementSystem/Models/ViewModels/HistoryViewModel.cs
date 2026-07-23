using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModels
{
    public class HistoryViewModel
    {
        public DateTime Date { get; set; }

        public string Product { get; set; } = string.Empty;

        public string TransactionType { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public int PreviousStock { get; set; }

        public int CurrentStock { get; set; }

        public string? ReferenceNo { get; set; }

        public string? Remarks { get; set; }
    }
}
