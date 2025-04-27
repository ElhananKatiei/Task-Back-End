using task.Models;
namespace task.Services;

public static class ManagerServise
{
    static List<Manager> Managers { get; set; }
    static ManagerServise()
    {
        Managers = [new Manager { Id = 1, Name = "Elhanan", Password = 1234,
        JobSites =
            [
                new JobSite{Id = 1, Name = "Bney Brak"}
                , new JobSite{Id = 2, Name = "Ali Hacoen"}
            ], Orders = [] }
        , new Manager { Id = 2, Name = "Yair", Password = 0000,
        JobSites =
            [
                new JobSite{Id = 3, Name = "Rabi Tarphon"}
                , new JobSite{Id = 4, Name = "Ben Gurion"}
            ], Orders = []}];
    }
    public static List<Manager> GetManagers()
    {
        return Managers;
    }

    public static string AddOrder(int idManager, Order order)
    {
        Manager? manager = Managers.Find(m => m.Id == idManager);
        if (manager != null)
        {
            manager.Orders.Add(order);
            return "Adding order succsed!";
        }
        return "Adding order faild!";
    }



    // public static void Add()
    // {
    //     Users.Add(new User { Id = 7, Name = "ll" });
    // }
}