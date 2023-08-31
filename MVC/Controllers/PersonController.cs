using Microsoft.AspNetCore.Mvc;
namespace MVC.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
         [HttpPost]
        public IActionResult Index(string FName)
    
        {
            ViewBag.thongBao = "xinchao" + FName;

            return View();
        }
    }
}