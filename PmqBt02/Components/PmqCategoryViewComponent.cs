using Microsoft.AspNetCore.Mvc;
using PmqBt02.Models;

namespace PmqBt02.Components
{
    public class PmqCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categoris = new List<PmqCategorys>
            {
                new PmqCategorys { PmqId = 1, PmqName = "Quần Áo" },
                new PmqCategorys { PmqId = 2, PmqName = "Túi xách" },
                new PmqCategorys { PmqId = 3, PmqName = "Đồng hồ" },
                new PmqCategorys { PmqId = 4, PmqName = "Ti vi" },
                new PmqCategorys { PmqId = 5, PmqName = "Tủ lạnh" },
                new PmqCategorys { PmqId = 6, PmqName = "Máy bơm" },
                new PmqCategorys { PmqId = 7, PmqName = "Quạt điện" },
                new PmqCategorys { PmqId = 8, PmqName = "Lò sưởi" }
            };
            return View(categoris);
        }
    }
}
