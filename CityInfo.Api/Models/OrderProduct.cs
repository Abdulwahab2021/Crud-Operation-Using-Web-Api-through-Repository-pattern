namespace CityInfo.Api.Models
{
    public class OrderProduct
    {

     public int ProductId { get; set; }
   public string ProductName { get; set; }

   public decimal  ProductPrice { get; set; }

   public ICollection<OrderProduct>? OrderProducts { get; set; }
   public int CategoryId { get; set; }
    }
}
