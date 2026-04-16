using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> dsSanPham = new List<Product>
        {
        };
        public IActionResult Index()
        {
            return View(dsSanPham);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Product p)
        {
            
            if (ModelState.IsValid)
            {
                dsSanPham.Add(p);
                return RedirectToAction("Index");

            }
            return View(p);
        }
    }
}


