using task.Models;
namespace task.Services;

public static class ProductServise
{
    static List<Product> products { get; set; }
    static ProductServise()
    {
       products = 
       [
            new Product {Id = 1, Name = "אבן", Price = 10},
            new Product {Id = 2, Name = "מריצה", Price = 20},
            new Product {Id = 3, Name = "ברזל", Price = 30},
            new Product {Id = 4, Name = "חוט", Price = 1},
            new Product {Id = 5, Name = "מסור", Price = 7},
            new Product {Id = 6, Name = "גבס", Price = 5},
            new Product {Id = 7, Name = "מנוף", Price = 100}
       ];
    }
    public static List<Product> GetProducts()
    {
        return products;
    }



    // public static void Add()
    // {
    //     Users.Add(new User { Id = 7, Name = "ll" });
    // }
}