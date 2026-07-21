using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User?> GetByUserNameAsync(string userName);

        Task<int> GetUserCountAsync();

        Task<bool> AnyUserExistsAsync();
    }
}
