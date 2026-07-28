using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class SalePurchaseDetail : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int SaleId { get; set; }

        public int PurchaseId { get; set; }

        public int Quantity { get; set; }

        // Cost Price of this Batch
        public decimal PurchasePrice { get; set; }

        [ForeignKey(nameof(SaleId))]
        public virtual Sale Sale { get; set; }

        [ForeignKey(nameof(PurchaseId))]
        public virtual PurchaseEntiity Purchase { get; set; }
    }
}
