using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PmqLesson09.Models.DataModels;
using PmqLesson09.Models.DataViewModels;

namespace PmqLesson09.Controllers
{
    public class PmqMemberController : Controller
    {
        private static List<PmqMember> _pmqMember = new List<PmqMember>();
        // GET: PmqMemberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PmqMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PmqMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PmqMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PmqMemberRegister PmqMember)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(PmqMember);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Có lỗi xảy ra: " + ex.Message);
                return View(PmqMember);
            }
        }

        // GET: PmqMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PmqMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PmqMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PmqMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
