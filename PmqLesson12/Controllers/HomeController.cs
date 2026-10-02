using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PmqLesson12.Models; // Đảm bảo namespace chứa DbContext của sản phẩm

namespace PmqLesson12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PmqProductDbContext _context; // Đổi lại đúng tên DbContext sản phẩm của bạn

        // Inject đúng DbContext mà các Controller sản phẩm đang dùng
        public HomeController(ILogger<HomeController> logger, PmqProductDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Product()
        {
            // Kiểm tra an toàn phòng trường hợp bảng Products chưa khởi tạo
            if (_context.Products == null)
            {
                return Problem("Entity set 'PmqProductDbContext.Products' is null.");
            }

            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}