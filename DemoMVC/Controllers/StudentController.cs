using Microsoft.AspNetCore.Mvc;//do duc tue 2121050190
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class StudentController:Controller
{
    public IActionResult Index()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Index(Student std)
    {
        string str = "hello " +  std.StudentID + " " + std.FullName;
        ViewBag.ThongBao = str;
        return View();
    }

}
}
