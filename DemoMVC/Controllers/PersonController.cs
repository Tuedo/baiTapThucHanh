using System.Security.AccessControl;
using System.Net;
// ho va ten do duc tue - mssv 2121050190
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
            string strOutput = "PersonId: " + ps.PersonId + " - " + "FullName: " + ps.FullName + " - " + "Address: " + ps.Address;
            ViewBag.ThongBao = strOutput;
            return View();
            
        }
    }
}