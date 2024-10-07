namespace CityInfo.Api.Models
{

       //Category class
    public class Category
    {
       public int CategoryId { get; set; }

public string CategoryName { get; set; }

public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
