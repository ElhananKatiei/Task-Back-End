namespace task.Models;

public class NewOrder
{
    public int IdManager {get; set;} 
    public Order Order {get; set;} = null!;
}

public class ProductAmount
{
    public Product Product { get; set; } = null!;
    public int Amount { get; set; }
}