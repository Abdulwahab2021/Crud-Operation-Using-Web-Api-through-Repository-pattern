namespace CityInfo.Api.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync();

        Task AddAsync(T entity);


        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);


    }
}
