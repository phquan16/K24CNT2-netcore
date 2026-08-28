using Microsoft.AspNetCore.Mvc;
using PmqLesson03.Models;

namespace PmqLesson03.Controllers
{
    [Route("/Danh-Sách-Sản-phẩm")]
    public class PmqProductController : Controller
    {
        // mốc data
        private readonly List<PmqProduct> _products = new()
        {
            new() { PmqProductId = "PMQ-TAC-001", PmqProductName = "Cám Chim Họa Mi Hót Cao Cấp", PmqYearRelease = 2022, PmqPrice = 120000m },
            new() { PmqProductId = "PMQ-TAC-002", PmqProductName = "Hạt Ngũ Cốc Dinh Dưỡng Cho Vẹt", PmqYearRelease = 2023, PmqPrice = 85000m },
            new() { PmqProductId = "PMQ-TAC-003", PmqProductName = "Cám Chào Mào Đấu Kích Hót", PmqYearRelease = 2021, PmqPrice = 150000m },
            new() { PmqProductId = "PMQ-TAC-004", PmqProductName = "Cám Chích Chòe Lửa Dưỡng Lông", PmqYearRelease = 2022, PmqPrice = 95000m },
            new() { PmqProductId = "PMQ-TAC-005", PmqProductName = "Côn Trùng Sấy Khô Cho Chim Cảnh", PmqYearRelease = 2023, PmqPrice = 65000m },
            new() { PmqProductId = "PMQ-TAC-006", PmqProductName = "Cám Khướu Tổng Hợp Đặc Biệt", PmqYearRelease = 2020, PmqPrice = 110000m },
            new() { PmqProductId = "PMQ-TAC-007", PmqProductName = "Hạt Láng Trắng Cho Chim Yến Phụng", PmqYearRelease = 2024, PmqPrice = 45000m },
            new() { PmqProductId = "PMQ-TAC-008", PmqProductName = "Thức Ăn Hạt Trộn Cho Chim Cu Gáy", PmqYearRelease = 2021, PmqPrice = 75000m },
            new() { PmqProductId = "PMQ-TAC-009", PmqProductName = "Cám Vành Khuyên Kích Sắc Tố Lông", PmqYearRelease = 2023, PmqPrice = 135000m },
            new() { PmqProductId = "PMQ-TAC-010", PmqProductName = "Cám Dinh Dưỡng Bổ Sung Cansi Cho Chim", PmqYearRelease = 2024, PmqPrice = 50000m }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }
        //collection => view
        [Route("all")]
        public IActionResult PmqGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
    }
}
