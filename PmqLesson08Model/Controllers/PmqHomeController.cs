using Microsoft.AspNetCore.Mvc;
using PmqLesson08Model.Models;
using System.Diagnostics;

namespace PmqLesson08Model.Controllers
{
    public class PmqHomeController : Controller
    {
        public IActionResult PmqIndex()
        {
            return View();
        }

        public IActionResult PmqPrivacy()
        {
            return View();
        }

        public IActionResult PmqAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
