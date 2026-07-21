using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services.UnitServices
{
    public class UnitService : IUnitService
    {
        private readonly IUnitRepository _unitRepository;

        public UnitService(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<List<Unit>> GetAllAsync()
        {
            return await _unitRepository.GetAllAsync();
        }

        public async Task<Unit?> GetByIdAsync(int id)
        {
            return await _unitRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Unit unit)
        {
            await _unitRepository.AddAsync(unit);
            await _unitRepository.SaveAsync();
        }

        public async Task UpdateAsync(Unit unit)
        {
            await _unitRepository.UpdateAsync(unit);
            await _unitRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var unit = await _unitRepository.GetByIdAsync(id);

            if (unit != null)
            {
                await _unitRepository.DeleteAsync(unit);
                await _unitRepository.SaveAsync();
            }
        }
    }
}
