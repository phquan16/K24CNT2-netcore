using Microsoft.AspNetCore.Mvc;
using PmqLesson02Theory.Models;

namespace PmqLesson02Theory.Controllers
{
    public class PmqProductController : Controller
    {
        public IActionResult PmqIndex()
        {
            // dữ liệu lưu trong đối tượng viewBag,viewData,tempData
            ViewBag.name = "Phạm Minh Quân";
            ViewData["productVd"] = "Asus Vivobook";
            TempData["uni"] = "Trường đại học Nguyễn Trãi - NTU";

            return View();
        }

        public IActionResult GetProduct()
        {
            //tạo mốc data product
            PmqProduct pmqProduct = new PmqProduct()
            {
                productID = "241090065",
                productName = "Phạm Minh Quân",
                YearRelease = 2006,
                price = 1000
            };

            ViewBag.product = pmqProduct;
            ViewData["product"] = pmqProduct;


            return View("product");
        }
    }
}
