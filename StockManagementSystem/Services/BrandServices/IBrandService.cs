using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.BrandServices
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllAsync();

        Task<Brand?> GetByIdAsync(int id);

        Task AddAsync(Brand brand);

        Task UpdateAsync(Brand brand);

        Task DeleteAsync(int id);
    }
}
