using StockManagementSystem.Interfaces;
using StockManagementSystem.Models.Master;

namespace StockManagementSystem.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Category category)
        {
            await _repository.AddAsync(category);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            await _repository.UpdateAsync(category);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category != null)
            {
                await _repository.DeleteAsync(category);
                await _repository.SaveAsync();
            }
        }
    }
}