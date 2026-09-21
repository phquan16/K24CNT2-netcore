using Microsoft.AspNetCore.Mvc;
using PmqBt04.Models;
using System.Diagnostics;

namespace PmqBt04.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
