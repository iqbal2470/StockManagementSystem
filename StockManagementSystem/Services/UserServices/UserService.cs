using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(User user)
        {
            await _userRepository.AddAsync(user);
            await _userRepository.SaveAsync();
        }

        public async Task UpdateAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user != null)
            {
                await _userRepository.DeleteAsync(user);
                await _userRepository.SaveAsync();
            }
        }

        public async Task<User?> GetByUserNameAsync(string userName)
        {
            return await _userRepository.GetByUserNameAsync(userName);
        }

        public async Task<int> GetUserCountAsync()
        {
            return await _userRepository.GetUserCountAsync();
        }

        public async Task<bool> AnyUserExistsAsync()
        {
            return await _userRepository.AnyUserExistsAsync();
        }
    }
}
