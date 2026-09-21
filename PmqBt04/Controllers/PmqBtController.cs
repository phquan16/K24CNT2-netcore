using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PmqBt04.Models;

namespace PmqBt04.Controllers
{
    public class PmqBtController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public PmqBtController(IWebHostEnvironment env)
        {
            _env = env;
        }
        // GET: PmqBtController
        public ActionResult Index()
        {
            var models = DataLocal.GetPmqBt();
            return View(models);
        }

        // GET: PmqBtController/Details/5
        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest();

            var bt = DataLocal.GetPmqBtById(id);
            if (bt == null) return NotFound();

            return View(bt);
        }

        // GET: PmqBtController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PmqBtController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PmqBt model, IFormFile? ImageFile)
        {
            try
            {
                if (ImageFile != null && ImageFile.Length > 0)
                {
                    // Tạo tên file duy nhất để không bị trùng
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);
                    string uploadPath = Path.Combine(_env.WebRootPath, "images", fileName);

                    // Đảm bảo thư mục images tồn tại
                    Directory.CreateDirectory(Path.Combine(_env.WebRootPath, "images"));

                    using (var stream = new FileStream(uploadPath, FileMode.Create))
                    {
                        ImageFile.CopyTo(stream);
                    }
                    model.PmqImages = fileName; // Lưu tên file mới
                }

                DataLocal._pmqBt.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Không thể thêm mới dữ liệu.");
            }
            return View(model);
        }

        // GET: PmqBtController/Edit/5
        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) 
                return BadRequest();
            var bt = DataLocal.GetPmqBtById(id);
            if (bt == null) return NotFound();
            return View(bt);
        }

        // POST: PmqBtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, PmqBt model, IFormFile? ImageFile)
        {
            try
            {
                var item = DataLocal.GetPmqBtById(id);
                if (item != null)
                {
                    item.PmqName = model.PmqName;
                    item.PmqPrice = model.PmqPrice;
                    item.PmqSalePrice = model.PmqSalePrice;
                    item.PmqStatus = model.PmqStatus;
                    item.PmqCreateDate = model.PmqCreateDate;
                    item.PmqCategoryId = model.PmqCategoryId;
                    item.PmqDescription = model.PmqDescription;

                    if (ImageFile != null && ImageFile.Length > 0)
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);
                        string uploadPath = Path.Combine(_env.WebRootPath, "images", fileName);

                        Directory.CreateDirectory(Path.Combine(_env.WebRootPath, "images"));

                        using (var stream = new FileStream(uploadPath, FileMode.Create))
                        {
                            ImageFile.CopyTo(stream);
                        }
                        item.PmqImages = fileName;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: PmqBtController/Delete/5
        public ActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) 
                return BadRequest();
            var bt = DataLocal.GetPmqBtById(id);
            if (bt == null) return NotFound();
            return View(bt);
        }

        // POST: PmqBtController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            var item = DataLocal.GetPmqBtById(id);
            if (item != null)
            {
                DataLocal._pmqBt.Remove(item);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
