using Microsoft.AspNetCore.Mvc;
using task.Models;
using task.Services;
namespace task.Controllers;

[ApiController]
[Route("{controller}")]
public class LoginController : ControllerBase
{
    [HttpPost]
    public ActionResult<Manager>? Login([FromBody] Login loginParams)
    {
        Manager? manager = LoginService.Login(loginParams);
        if (manager != null)
        {
            return manager;
        }
        return null;
    }
}