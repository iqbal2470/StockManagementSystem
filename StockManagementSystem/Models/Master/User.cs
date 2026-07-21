using StockManagementSystem.Models.Common;

namespace StockManagementSystem.Models.Master
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public DateTime? LastLogin { get; set; }
    }
}