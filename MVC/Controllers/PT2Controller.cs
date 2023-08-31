using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
namespace MVC.Controllers
{
    public class PT2Controller : Controller
    {
        [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
        
    [HttpPost]
     public IActionResult PT2(double a, double b, double c)
    {
        double delta = b*b - 4*a*c;
        if(delta < 0)
        {
            ViewBag.kq = $"Phuong trinh vo nghiem";
        }
        if(delta == 0)
        {
            double x = -b/2*a;
            ViewBag.kq = $"phuong trinh co nghiem kep {x}";
        }
        if(delta > 0)
        {
            double x1 = (- b + Math.Sqrt(delta))/2*a;
            double x2 = (- b - Math.Sqrt(delta))/2*a;
            ViewBag.kq = $"phuong trinh co 2 nghiem phan biet la : X1 ={x1}, X2 ={x2}";
        }
        return View("Index");
    }
    }
}
