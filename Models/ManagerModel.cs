namespace task.Models;
public class Manager{
    public int Id {get; set;}
    public string Name {get; set;} = null!;
    public int Password {get; set;}
    public List<JobSite> JobSites {get; set;} = null!;
    public List<Order> Orders { get; set; } = null!;
}