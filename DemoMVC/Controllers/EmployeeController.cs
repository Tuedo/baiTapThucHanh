// ho va ten do duc tue 2121050190

using System.Net;
using System;
using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(string HoTen, float LuongCoBan, float HeSoLuong, float PhuCap)
        {
            int Luong = Convert.ToInt32( (LuongCoBan*HeSoLuong) + PhuCap );
            string ThongBao = "Họ và Tên: "+ HoTen +" || "+ "Lương: " + Luong +" VNĐ";

            ViewBag.ThongBao = ThongBao;
            return View();
        }
    }
}