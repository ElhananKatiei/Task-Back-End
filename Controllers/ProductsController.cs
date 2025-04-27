using Microsoft.AspNetCore.Mvc;
using task.Models;
using task.Services;
namespace task.Controllers;

[ApiController]
[Route("{controller}")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Product>> GetAllProducts()
    {
        return ProductServise.GetProducts();
    }
}