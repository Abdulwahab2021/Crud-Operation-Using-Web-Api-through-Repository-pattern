using CityInfo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.Api.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) { }
        
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<OrderProduct> OrderProduct { get; set; }





    }
}
