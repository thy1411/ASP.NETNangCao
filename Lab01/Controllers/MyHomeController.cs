using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class MyHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chao() { return Content("Hello here"); }
    }
}
