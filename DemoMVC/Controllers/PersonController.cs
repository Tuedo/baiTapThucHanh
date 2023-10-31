using System.Net;
// Ho Va Ten :Do Duc Tue || Ma Sinh Vien : 2121050190
using DemoMVC.Models;


using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(Person ps)
        {
            string strOutput = "Hello " + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
            
        }
    }
}