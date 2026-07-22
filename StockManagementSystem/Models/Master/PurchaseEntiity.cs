using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class PurchaseEntiity : BaseEntity
    {
        public string PurchaseNo { get; set; } = string.Empty;

        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public decimal PurchasePrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalAmount { get; set; }

        public string? Remarks { get; set; }
    }
}
