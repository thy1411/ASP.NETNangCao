using Lab01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;

namespace Lab01.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var lst = new List<Student>();
            lst.Add(new Student{ Id = 1, Name = "Thy", Age = 20 });
            lst.Add(new Student { Id = 1, Name = "Tiên", Age = 20 });
            return View(lst);
        }
    }
}
