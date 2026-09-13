using Microsoft.AspNetCore.Mvc;
using PmqBt02.Models;

namespace PmqBt02.Controllers
{
    public class PmqProductController : Controller
    {
        public IActionResult Index()
        {
            List<PmqProducts> pmqProducts = new List<PmqProducts>
            {
                new PmqProducts
                {
                    PmqId = 1,
                    PmqName = "Bộ đồ bơi cho trẻ em nam",
                    PmqImages = "/images/1.jpg",
                    PmqPrice = 50000m,
                    PmqPriceSale = 35000m,
                    PmqCategoryId = 1, 
                    PmqDescription = "Bộ đồ bơi dành cho trẻ em nam, chất liệu co giãn 4 chiều thoải mái.",
                    PmqStatus = true,
                    PmqCreatedAt = DateTime.Now
                },
                new PmqProducts
                {
                    PmqId = 2,
                    PmqName = "Bộ đồ bơi cho trẻ em nữ",
                    PmqImages = "/images/2.jpg",
                    PmqPrice = 50000m,
                    PmqPriceSale = 35000m,
                    PmqCategoryId = 1, 
                    PmqDescription = "Bộ đồ bơi nữ cho bé, thiết kế dễ thương, chất vải nhanh khô.",
                    PmqStatus = true,
                    PmqCreatedAt = DateTime.Now
                },
                new PmqProducts
                {
                    PmqId = 3,
                    PmqName = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi",
                    PmqImages = "/images/3.jpg",
                    PmqPrice = 50000m,
                    PmqPriceSale = 35000m,
                    PmqCategoryId = 1, 
                    PmqDescription = "Size chuẩn cho các bé từ 3 đến 5 tuổi, bảo vệ da bé chống tia UV.",
                    PmqStatus = true,
                    PmqCreatedAt = DateTime.Now
                },
                new PmqProducts
                {
                    PmqId = 4,
                    PmqName = "Bộ đồ bơi cho trẻ em thời trang",
                    PmqImages = "/images/4.jpg",
                    PmqPrice = 50000m,
                    PmqPriceSale = 35000m,
                    PmqCategoryId = 1, 
                    PmqDescription = "Mẫu đồ bơi thời trang mới nhất, phối màu bắt mắt.",
                    PmqStatus = true,
                    PmqCreatedAt = DateTime.Now
                },
                new PmqProducts
                {
                    PmqId = 5,
                    PmqName = "Túi thời trang mẫu mới 2021",
                    PmqImages = "/images/5.jpg",
                    PmqPrice = 50000m,
                    PmqPriceSale = 35000m,
                    PmqCategoryId = 2, 
                    PmqDescription = "Túi xách thời trang cao cấp, kiểu dáng trẻ trung năng động.",
                    PmqStatus = true,
                    PmqCreatedAt = DateTime.Now
                }
            };
            return View(pmqProducts);
        }

        public IActionResult Details(int id)
        {

            List<PmqProducts> pmqProducts = new List<PmqProducts>
            {
                new PmqProducts { PmqId = 1, PmqName = "Bộ đồ bơi cho trẻ em nam", PmqImages = "/images/1.jpg", PmqPrice = 50000m, PmqPriceSale = 35000m, PmqCategoryId = 1, PmqDescription = "Bộ đồ bơi dành cho trẻ em nam, chất liệu co giãn 4 chiều thoải mái.", PmqStatus = true, PmqCreatedAt = DateTime.Now },
                new PmqProducts { PmqId = 2, PmqName = "Bộ đồ bơi cho trẻ em nữ", PmqImages = "/images/2.jpg", PmqPrice = 50000m, PmqPriceSale = 35000m, PmqCategoryId = 1, PmqDescription = "Bộ đồ bơi nữ cho bé, thiết kế dễ thương, chất vải nhanh khô.", PmqStatus = true, PmqCreatedAt = DateTime.Now },
                new PmqProducts { PmqId = 3, PmqName = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", PmqImages = "/images/3.jpg", PmqPrice = 50000m, PmqPriceSale = 35000m, PmqCategoryId = 1, PmqDescription = "Size chuẩn cho các bé từ 3 đến 5 tuổi, bảo vệ da bé chống tia UV.", PmqStatus = true, PmqCreatedAt = DateTime.Now },
                new PmqProducts { PmqId = 4, PmqName = "Bộ đồ bơi cho trẻ em thời trang", PmqImages = "/images/4.jpg", PmqPrice = 50000m, PmqPriceSale = 35000m, PmqCategoryId = 1, PmqDescription = "Mẫu đồ bơi thời trang mới nhất, phối màu bắt mắt.", PmqStatus = true, PmqCreatedAt = DateTime.Now },
                new PmqProducts { PmqId = 5, PmqName = "Túi thời trang mẫu mới 2021", PmqImages = "/images/5.jpg", PmqPrice = 50000m, PmqPriceSale = 35000m, PmqCategoryId = 2, PmqDescription = "Túi xách thời trang cao cấp, kiểu dáng trẻ trung năng động.", PmqStatus = true, PmqCreatedAt = DateTime.Now }
            };

            var product = pmqProducts.FirstOrDefault(p => p.PmqId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
