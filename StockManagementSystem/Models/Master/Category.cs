using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = string.Empty;

        public string? CategoryDescription { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
