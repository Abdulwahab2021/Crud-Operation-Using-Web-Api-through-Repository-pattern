namespace CityInfo.Api.Models
{
    public class Order
    {

           public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    
   // Add Foreign Key
    public int CustomerId { get; set; }
//Navigation property
    public Customer Customer { get; set; }

    public ICollection<OrderProduct>? OrderProducts { get; set; }

    }
}
