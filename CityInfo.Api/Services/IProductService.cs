using CityInfo.Api.Model;

namespace CityInfo.Api.Services
{
    //IProductService
    public interface IProductService
    {
         Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<bool> AddProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);

    }
}
