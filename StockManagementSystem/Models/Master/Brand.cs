using StockManagementSystem.Models.Common;

namespace StockManagementSystem.Models.Master
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}