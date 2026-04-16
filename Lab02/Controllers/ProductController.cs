using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> dsSanPham = new List<Product>
        {
            new Product {Id = 1, Name = "ThyThy", Price = 30000000}
        };
        //trả về giao diện hiển thị  danh sách sản phẩm
        public IActionResult Index()
        {
            return View(dsSanPham);
        }
        //trả về giao diện nhập thông tin sản phẩm cần thêm
        public IActionResult Create()
        {
            return View();
        }
        //Xử lý thêm mới sản phẩm vào danh sách
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


