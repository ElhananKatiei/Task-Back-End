namespace task.Models;

public class Order{
    public JobSite JobSite {get; set;} = null!;
    public ProductAmount ProductAmount {get; set;} = null!;
    public int TotalPrice {get; set;} 
}