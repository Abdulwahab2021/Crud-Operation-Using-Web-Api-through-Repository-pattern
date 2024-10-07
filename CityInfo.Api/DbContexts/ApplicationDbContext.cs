using CityInfo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.Api.DbContexts
{

    // ApplicationDbContext
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) { }
        
         public DbSet<Product> Products { set; get; }
 public DbSet<Order> Orders { set; get; }

 public DbSet<Customer> Customers { set; get; }
 public DbSet<Category> categories { set; get; }

 public DbSet<OrderProduct> orderProducts { set; get; }


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {


      modelBuilder.Entity<Customer>().HasData(
          new Customer { CustomerId = 1, Name = "Ali", Email = "ali@gmail.com" },
           new Customer { CustomerId = 2, Name = "Nawaz", Email = "Nawaz@gmail.com" }

          );

      modelBuilder.Entity<Category>().HasData(
     new Category { CategoryId = 1, CategoryName = "Electronics" },
     new Category { CategoryId = 2, CategoryName = "Clothing" }
 );

      // Seed Products
      modelBuilder.Entity<Product>().HasData(
          new Product { ProductId = 1, ProductName = "Smartphone", ProductPrice = 699.99M, CategoryId = 1 },
          new Product { ProductId = 2, ProductName = "Laptop", ProductPrice = 999.99M, CategoryId = 1 },
          new Product { ProductId = 3, ProductName = "T-Shirt", ProductPrice = 19.99M, CategoryId = 2 }
      );

      modelBuilder.Entity<Order>().HasData(
          new Order { OrderId = 1, OrderDate = DateTime.Now, CustomerId = 1 },
           new Order { OrderId = 2, OrderDate = DateTime.Now, CustomerId = 1 },
            new Order { OrderId = 3, OrderDate = DateTime.Now, CustomerId = 2 },
              new Order { OrderId = 4, OrderDate = DateTime.Now, CustomerId = 2 }
          );
      // Define composite primary key
      modelBuilder.Entity<OrderProduct>()
      .HasKey(op => new { op.OrderId, op.ProductId });


      modelBuilder.Entity<OrderProduct>().HasData(
      new OrderProduct { OrderId = 1, ProductId=1  },
       new OrderProduct { OrderId = 1, ProductId=2},
        new OrderProduct { OrderId = 2,ProductId= 1},
          new OrderProduct { OrderId = 4,ProductId=2}
      );



      base.OnModelCreating(modelBuilder);

      // Configure many-to-many relationship between Order and Product
      modelBuilder.Entity<OrderProduct>()
          .HasKey(op => new { op.OrderId, op.ProductId });

      modelBuilder.Entity<OrderProduct>()
          .HasOne(op => op.Order)
          .WithMany(op => op.OrderProducts)
          .HasForeignKey(op => op.OrderId);
      modelBuilder.Entity<OrderProduct>()
          .HasOne(op=>op.Product)
          .WithMany(op=>op.OrderProducts)
          .HasForeignKey(op => op.ProductId);
        


  }
    
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


  {

      base.OnConfiguring(optionsBuilder);
  }


    }
}
