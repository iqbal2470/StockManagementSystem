using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.BrandServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            return await _brandRepository.GetAllAsync();
        }

        public async Task<Brand?> GetByIdAsync(int id)
        {
            return await _brandRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Brand brand)
        {
            await _brandRepository.AddAsync(brand);
            await _brandRepository.SaveAsync();
        }

        public async Task UpdateAsync(Brand brand)
        {
            await _brandRepository.UpdateAsync(brand);
            await _brandRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);

            if (brand != null)
            {
                await _brandRepository.DeleteAsync(brand);
                await _brandRepository.SaveAsync();
            }
        }
    }
}
