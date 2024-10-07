using CityInfo.Api.Data;
using CityInfo.Api.Model;

namespace CityInfo.Api.Repository
{
    public interface IProductRepository : IGenericRepository<Product ,  MyDbContext>
    {
        Task<Product> GetUserByUserNameAsync(int categoryId);
    }
}
