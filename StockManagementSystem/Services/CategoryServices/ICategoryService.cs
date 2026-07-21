using StockManagementSystem.Models.Master;

namespace StockManagementSystem.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();

        Task<Category?> GetByIdAsync(int id);

        Task AddAsync(Category category);

        Task UpdateAsync(Category category);

        Task DeleteAsync(int id);
    }
}