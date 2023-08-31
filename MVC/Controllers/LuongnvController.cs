using MVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace MVC.Controllers
{
    public class LuongnvController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
         [HttpPost]
        public IActionResult Luongnv(double Luongcb, double HeSo, double PhuCap)
        {
            double TongLuong = Luongcb * HeSo + PhuCap;
            ViewBag.luong = $"Luong cua ban la : {TongLuong}";
            return View("Index");
        }
    }
}