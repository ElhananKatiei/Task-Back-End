using task.Models;
namespace task.Services;

public static class OrderService
{
    public static bool AddNewOrder(NewOrder newOrder)
    {
        Manager? manager = ManagerServise.GetManagers().Find(m => m.Id == newOrder.IdManager);
        if (manager != null)
        {
            manager.Orders.Add(newOrder.Order);
            return true;
        }
        return false;
    }
}