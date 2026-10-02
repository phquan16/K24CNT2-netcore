using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PmqLesson12.Data;
using PmqLesson12.Models; 

namespace PmqLesson12.Controllers
{
    public class PmqProductController : Controller
    {
        private readonly PmqProductDbContext _context; 

        public PmqProductController(PmqProductDbContext context)
        {
            _context = context;
        }

        // GET: PmqProduct
        public async Task<IActionResult> Index(string searchString)
        {
            var products = from p in _context.Products
                           select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.PmqName!.Contains(searchString) || s.PmqId!.Contains(searchString));
            }

            ViewData["CurrentFilter"] = searchString;
            return View(await products.ToListAsync());
        }

        // GET: PmqProduct/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.PmqId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: PmqProduct/Create
        public IActionResult Create()
        {
            // Nếu có bảng Category, bạn có thể truyền ViewData["PmqCategoryId"] vào đây để làm DropdownList
            return View();
        }

        // POST: PmqProduct/Create
        // POST: PmqProduct/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PmqId,PmqName,PmqPrice,PmqSalePrice,PmqStatus,PmqCreateDate,PmqCategoryId,PmqDescription")] Product product, IFormFile? imageFile)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra trùng mã ID
                var existing = await _context.Products.FindAsync(product.PmqId);
                if (existing != null)
                {
                    ModelState.AddModelError("PmqId", "Mã sản phẩm này đã tồn tại.");
                    return View(product);
                }

                // Xử lý upload file ảnh lên thư mục wwwroot/images
                if (imageFile != null && imageFile.Length > 0)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    string uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");

                    // Nếu chưa có thư mục thì tự động tạo mới
                    if (!Directory.Exists(uploadDir))
                    {
                        Directory.CreateDirectory(uploadDir);
                    }

                    string filePath = Path.Combine(uploadDir, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }

                    // Lưu đường dẫn tương đối vào database để hiển thị
                    product.PmqImages = "/images/products/" + fileName;
                }

                if (product.PmqCreateDate == default)
                {
                    product.PmqCreateDate = DateTime.Now;
                }

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: PmqProduct/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: PmqProduct/Edit/5
        // POST: PmqProduct/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PmqId,PmqName,PmqPrice,PmqSalePrice,PmqStatus,PmqCreateDate,PmqImages,PmqCategoryId,PmqDescription")] Product product, IFormFile? imageFile)
        {
            if (id != product.PmqId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Nếu người dùng chọn ảnh mới từ máy
                    if (imageFile != null && imageFile.Length > 0)
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                        string uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");

                        if (!Directory.Exists(uploadDir))
                        {
                            Directory.CreateDirectory(uploadDir);
                        }

                        string filePath = Path.Combine(uploadDir, fileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(fileStream);
                        }

                        // Cập nhật đường dẫn ảnh mới vào model
                        product.PmqImages = "/images/products/" + fileName;
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.PmqId)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: PmqProduct/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.PmqId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: PmqProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string id)
        {
            return _context.Products.Any(e => e.PmqId == id);
        }
    }
}