using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.UserServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<User?> GetByIdAsync(int id);

        Task AddAsync(User user);

        Task UpdateAsync(User user);

        Task DeleteAsync(int id);

        Task<User?> GetByUserNameAsync(string userName);

        Task<int> GetUserCountAsync();

        Task<bool> AnyUserExistsAsync();
    }
}
