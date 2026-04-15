using Lab01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Lab01.Controllers
{
    public class RegisterController : Controller
    {
        private IWebHostEnvironment hosting;

        public RegisterController(IWebHostEnvironment _hosting)
        {
            hosting = _hosting;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult XuLy(PersonViewModel m, IFormFile FHinh)
        {
            if (FHinh != null)
            {
                string filename = Guid.NewGuid().ToString()
                                  + Path.GetExtension(FHinh.FileName);

                string path = Path.Combine(hosting.WebRootPath, "images");

                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    FHinh.CopyTo(filestream);
                }

                m.hinhanh = filename;
            }

            return View(m);
        }
    }
}