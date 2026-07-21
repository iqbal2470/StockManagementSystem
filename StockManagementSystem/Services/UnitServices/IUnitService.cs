using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.UnitServices
{
    public interface IUnitService
    {
        Task<List<Unit>> GetAllAsync();
        Task<Unit?> GetByIdAsync(int id);
        Task AddAsync(Unit unit);
        Task UpdateAsync(Unit unit);
        Task DeleteAsync(int id);
    }
}
