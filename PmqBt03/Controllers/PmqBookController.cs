using Microsoft.AspNetCore.Mvc;
using PmqBt03.Models;

namespace PmqBt03.Controllers
{
    public class PmqBookController : Controller
    {
        protected PmqBook book = new PmqBook();
        public IActionResult Index()
        {
            ViewBag.athors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.athors = book.Authors;
            ViewBag.genres = book.Genres;
            var model = new PmqBook();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.athors = book.Authors;
            ViewBag.genres = book.Genres;
            var model = book.GetPmqBookById(id);
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}
