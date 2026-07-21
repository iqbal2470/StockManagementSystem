using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.BrandServices
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;

        public BrandService(IBrandRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Brand?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Brand brand)
        {
            await _repository.AddAsync(brand);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(Brand brand)
        {
            await _repository.UpdateAsync(brand);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var brand = await _repository.GetByIdAsync(id);

            if (brand != null)
            {
                await _repository.DeleteAsync(brand);
                await _repository.SaveAsync();
            }
        }
    }
}
