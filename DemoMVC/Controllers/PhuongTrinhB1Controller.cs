using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
// 2121050190 ho va ten do duc tue

namespace DemoMVC.Controllers
{
    public class PhuongTrinhB1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(double a, double b)
        {
            if (a==0)
            {
                if (b==0)
                {
                    ViewBag.ThongBao = "Phuong Trinh Co Vo So Nghiem";
                }else{
                    ViewBag.ThongBao = "Phuong Trinh Vo Nghiem";
                }
            }else{
                double x = -b/a;
                ViewBag.ThongBao = $"Phuong trinh co nghiem la: x = {x}";
            }
            
             return View();
        }

            
    }
}

    