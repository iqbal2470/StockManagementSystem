using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModels
{
    public class PurchaseViewModel
    {
        public int Id { get; set; }

        public string PurchaseNo { get; set; } = "";

        public DateTime PurchaseDate { get; set; }

        public string ProductName { get; set; } = "";

        public decimal PurchasePrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalAmount { get; set; }

        public string? Remarks { get; set; }
    }
}
