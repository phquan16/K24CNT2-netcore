using Microsoft.AspNetCore.Mvc;
using PmqBt03.Models;

namespace PmqBt03.ViewComponents
{
    public class PmqBookViewComponent : ViewComponent
    {
        protected PmqBook book = new PmqBook();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}
