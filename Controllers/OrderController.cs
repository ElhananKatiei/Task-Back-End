using Microsoft.AspNetCore.Mvc;
using task.Models;
using task.Services;
namespace task.Controllers;

[ApiController]
[Route("{controller}")]
public class OrderController : ControllerBase
{
    [HttpPost]
    public ActionResult<Manager?> AddNewOrder([FromBody] NewOrder newOrder)
    {
        OrderService.AddNewOrder(newOrder);
        return ManagerServise.GetManagerById(newOrder.IdManager);
    }
}