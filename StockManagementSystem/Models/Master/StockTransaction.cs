using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class StockTransaction : BaseEntity
    {
        public int ProductId { get; set; }

        public TransactionType TransactionType { get; set; }

        public int Quantity { get; set; }

        public int PreviousStock { get; set; }

        public int CurrentStock { get; set; }

        public string? ReferenceNo { get; set; }

        public string? Remarks { get; set; }

        public string? ReferenceType { get; set; }

        // Navigation Property
        public virtual Product Product { get; set; }
    }
    public enum TransactionType
    {
        OpeningStock = 1,

        ProductUpdate = 2,
        ProductDelete = 3,

        Purchase = 4,
        PurchaseUpdate = 5,
        PurchaseDelete = 6,

        Sale = 7,
        SaleUpdate = 8,
        SaleDelete = 9,

        Adjustment = 10
    }
    //public enum TransactionType
    //{
    //    OpeningStock = 1,

    //    Purchase = 2,
    //    PurchaseUpdate = 3,
    //    PurchaseDelete = 4,

    //    Sale = 5,
    //    SaleUpdate = 6,
    //    SaleDelete = 7,

    //    Adjustment = 8
    //}
}
