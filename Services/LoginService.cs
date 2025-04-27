using task.Models;
namespace task.Services;

public static class LoginService
{
    public static Manager? Login(Login login)
    {
        List<Manager> managers = ManagerServise.GetManagers();
        return managers.Find(m => m.Password == login.Password & m.Name == login.Name);
    }
}