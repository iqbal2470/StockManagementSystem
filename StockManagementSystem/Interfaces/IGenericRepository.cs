using System.Linq.Expressions;

namespace StockManagementSystem.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<T?> GetByIdAsync(int id);

        Task<T?> FindAsync(Expression<Func<T, bool>> predicate);

        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task SaveAsync();
    }
}