using CityInfo.Api.Data;
using CityInfo.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.Api.Repository
{
    // Product repository
    public class ProductRepository:GenericRepository<Product,MyDbContext> , IProductRepository

    {
        public ProductRepository(MyDbContext context) : base(context) {
        
        
        }

        public async Task<Product> GetUserByUserNameAsync(int categoryId)
        {
            return await _myDbContext.Products.Where(a =>a.CategoryId== categoryId).FirstOrDefaultAsync();
        }


        public override async Task<bool> AddAsync(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName)) throw new ArgumentNullException("Product should have a name");
         

            var result = await base.AddAsync(product);
            return result;
        }

        public override async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await base.GetAllAsync();
            return result;
        }



        public override async Task<Product> GetIDbAsync(int Id)
        {
            var result = await base.GetIDbAsync(Id);
            return result;

        }


        public override async Task<bool> UpdateAsync(Product product)
        {
            var result = await base.UpdateAsync(product);
            return result;
           
        }

        public override async Task<bool> DeleteAsync(int Id)
        {
            var result = await base.DeleteAsync(Id);
            return result;

        }






        // Example of a custom method to get products by category
        //public IEnumerable<Product> GetProductsByCategory(string category)
        //{

        //}
        //public IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        //{
        //    return _myDbContext.orderProductsByPriceRange(minPrice, maxPrice);
        //}

        //public async Task<User> GetUserByUserNameAsync(string username)
        //{
        //    return await _context.Users.SingleOrDefaultAsync(u => u.username == username);
        //}

    }
}
