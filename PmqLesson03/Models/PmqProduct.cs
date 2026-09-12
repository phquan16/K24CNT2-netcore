using Microsoft.AspNetCore.Mvc;

namespace PmqLesson03.Models
{
    public class PmqProduct : Controller
    {
        public string PmqProductID { get; set; }
        public string PmqProductName { get; set; }
        public int PmqYearRelease { get; set; }
        public decimal PmqPrice { get; set; }

    }
}
