using StockManagementSystem.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class Unit : BaseEntity
    {
        public string UnitName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
