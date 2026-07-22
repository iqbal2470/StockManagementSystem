using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class Sale : BaseEntity
    {
        public string SaleNo { get; set; } = string.Empty;

        public DateTime SaleDate { get; set; } = DateTime.Now;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public decimal SalePrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalAmount { get; set; }

        public string? Remarks { get; set; }
    }
}
