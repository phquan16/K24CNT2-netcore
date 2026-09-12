using Microsoft.AspNetCore.Mvc;
using PmqLesson02theory.Models;

namespace PmqLesson02theory.Controllers
{
    public class PmqProductController : Controller
    {
        public IActionResult PmqIndex()
        {
            ViewBag.Name = "Phạm Minh Quân";
            ViewData["productVD"] = "Laptop ASUA";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi - NTU";
            return View();
        }

        public IActionResult GetProduct()
        {
            PmqProduct pmqProduct = new PmqProduct()
            {
                ProductID = "2410900065",
                ProductName = "Phạm Minh Quân",
                YearRelease = 2006,
                Price = 1000
            };

            ViewBag.PmqProduct = pmqProduct;
            ViewData["product"] = pmqProduct;
            return View("Product");
        }
    }
}
