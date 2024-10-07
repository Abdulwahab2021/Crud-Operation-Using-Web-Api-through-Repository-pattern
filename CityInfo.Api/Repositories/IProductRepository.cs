using CityInfo.Api.Data;
using CityInfo.Api.Model;

namespace CityInfo.Api.Repository
{
    // IProduct repository
    public interface IProductRepository : IGenericRepository<Product ,  MyDbContext>
    {
        Task<Product> GetUserByUserNameAsync(int categoryId);
    }
}
