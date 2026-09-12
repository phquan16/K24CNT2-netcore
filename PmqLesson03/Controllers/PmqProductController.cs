using Microsoft.AspNetCore.Mvc;
using PmqLesson03.Models;

namespace PmqLesson03.Controllers
{
    [Route("/danh-sach-san-pham")]

    public class PmqProductController : Controller
    {
            // Mock data
            private readonly List<PmqProduct> _products = new()
            {
                new PmqProduct
                {
                    PmqProductID = "MB-001",
                    PmqProductName = "iPhone 15 Pro Max",
                    PmqYearRelease = 2023,
                    PmqPrice = 29990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-002",
                    PmqProductName = "Samsung Galaxy S24 Ultra",
                    PmqYearRelease = 2024,
                    PmqPrice = 31990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-003",
                    PmqProductName = "Xiaomi 14 Ultra",
                    PmqYearRelease = 2024,
                    PmqPrice = 27990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-004",
                    PmqProductName = "Google Pixel 8 Pro",
                    PmqYearRelease = 2023,
                    PmqPrice = 22500000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-005",
                    PmqProductName = "OPPO Find N3 Flip",
                    PmqYearRelease = 2023,
                    PmqPrice = 19990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-006",
                    PmqProductName = "ASUS ROG Phone 8 Pro",
                    PmqYearRelease = 2024,
                    PmqPrice = 28990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-007",
                    PmqProductName = "Samsung Galaxy Z Fold5",
                    PmqYearRelease = 2023,
                    PmqPrice = 34990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-008",
                    PmqProductName = "iPhone 13",
                    PmqYearRelease = 2021,
                    PmqPrice = 13990000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-009",
                    PmqProductName = "Xiaomi Redmi Note 13 Pro",
                    PmqYearRelease = 2024,
                    PmqPrice = 7290000m
                },
                new PmqProduct
                {
                    PmqProductID = "MB-010",
                    PmqProductName = "Realme 12 Pro+",
                    PmqYearRelease = 2024,
                    PmqPrice = 9990000m
                }
            };

            public IActionResult Index()
            {
                return Json(_products);
            }

            // Collection => view
            [Route("all")]
            public IActionResult PmqGetAllProduct()
            {
                ViewData["products"] = _products;
                return View();
            }
        
    }
}
