using System.Linq.Expressions;

namespace CityInfo.Api.Repository
{
    public interface IGenericRepository<T,TContext> where T : class where TContext : class
    {

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetIDbAsync(int Id);
        Task<bool> AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int Id);
    }
}
