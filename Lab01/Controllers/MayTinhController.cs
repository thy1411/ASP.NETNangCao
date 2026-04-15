using Lab01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class MayTinhController : Controller
    {
        //action trả về giao diện nhập liệu
        public IActionResult Index()
        {
            return View();
        }

        //1. Tiếp nhận thông số thông qua Request.Form
        //public IActionResult TinhToan()
        //{
        //    //Lấy tham số
        //    double x = double.Parse(Request.Form["so1"]);
        //    double y = double.Parse(Request.Form["so2"]);
        //    string pheptinh = Request.Form["pheptinh"];
        //    double kq = 0;
        //    switch (pheptinh)
        //    {
        //        case "+": kq = x + y;
        //            break;
        //        case "-":
        //            kq = x - y;
        //            break;
        //        case "*":
        //            kq = x * y;
        //            break;
        //        case "/":
        //                    {
        //                        if (x != 0)
        //                        {
        //                            kq = x / y;
        //                        }
        //                        else
        //                        {
        //                            return Content("Lỗi: Không thể chia cho 0");
        //                        }
        //                    }
        //                    break;
        //    }
        //    return Content("Ket qua = " + kq);
        //}

        //2. Tiếp nhận thông số thông qua tham số của action

        //public IActionResult TinhToan(double so1, double so2, string pheptinh)
        //        {
        //            //Lấy tham số
        //            //double x = double.Parse(Request.Form["so1"]);
        //            //double y = double.Parse(Request.Form["so2"]);
        //            //string pheptinh = Request.Form["pheptinh"];
        //            double kq = 0;
        //            switch (pheptinh)
        //            {
        //                case "+":
        //                    kq = so1 + so2;
        //                    break;
        //                case "-":
        //                    kq = so1 - so2;
        //                    break;
        //                case "*":
        //                    kq = so1 * so2;
        //                    break;
        //                case "/":
        //                    {
        //                        if (so2 != 0)
        //                        {
        //                            kq = so1 / so2;
        //                        }
        //                        else
        //                        {
        //                            return Content("Lỗi: Không thể chia cho 0");
        //                        }
        //                    }
        //                    break;

        //            }
        //            return Content("Ket qua = " + kq);
        //        }

        //3. Tiếp nhận thông số thông qua model
        public IActionResult TinhToan(MayTinh m)
        {
            //Lấy tham số
            //double x = double.Parse(Request.Form["so1"]);
            //double y = double.Parse(Request.Form["so2"]);
            //string pheptinh = Request.Form["pheptinh"];
            double kq = 0;
            switch (m.pheptinh)
            {
                case "+":
                    kq = m.so1 + m.so2;
                    break;
                case "-":
                    kq = m.so1 - m.so2;
                    break;
                case "*":
                    kq = m.so1 * m.so2;
                    break;
                case "/":
                    {
                        if (m.so2 != 0)
                        {
                            kq = m.so1 / m.so2;
                        }
                        else
                        {
                            return Content("Lỗi: Không thể chia cho 0");
                        }
                    }
                    break;

            }
            //Gửi dữ liệu sang view
            ViewBag.KQ = kq;   //cách cũ ViewData["KQ"] = kq;
            return View("Index");
        }
    }
}
