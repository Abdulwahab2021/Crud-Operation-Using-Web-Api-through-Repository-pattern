using CityInfo.Api.Model;
using CityInfo.Api.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CityInfo.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> AddProduct(Product product)
        {
         var result=  await _productRepository.AddAsync(product);
            return result;
        }

        public async Task<bool> DeleteProduct(int id)
        {
          var result =await  _productRepository.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable <Product>> GetAllProducts()
        {
          var product= await _productRepository.GetAllAsync();
            return product;
           
        }


        public async Task<Product> GetProductById(int id)
        {
          var product=await  _productRepository.GetIDbAsync(id);
            return product;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
          var result= await _productRepository.UpdateAsync(product);
            return result;
        }
    }
}
