namespace CityInfo.Api.Models
{
    public class Order
    {

        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        // Foreign Keys
     public ICollection<Product> products { get; set; }

        // Foreign Keys
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }




    }
}
