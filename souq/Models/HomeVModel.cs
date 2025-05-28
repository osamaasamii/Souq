namespace souq.Models
{
    public class HomeVModel
    {
     
         public List<Product> Products { get; set; } 
         public List<Product> LatestProduct { get; set; } 
         public List<Category> Categories { get; set; } 
         public List<Review> Reviews { get; set; }

    }
}
