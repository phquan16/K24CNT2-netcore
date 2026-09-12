using Microsoft.AspNetCore.Mvc;
using PmqLesson04lab.Models;
using System.Security.Principal;

namespace PmqLesson04lab.Controllers
{
    public class PmqAccountController : Controller
    {
        private readonly List<PmqAccount> pmqAccounts = new()
        {
            new PmqAccount
            {
                Id = 1, Name = "Đặng Vũ Hải",
                Email = "hai.dang@gmail.com",
                Phone = "0981112233",
                Address = "Cần Thơ",
                Avatar = "/images/bn1.jpg",
                Gender = 1, Bio = "Thích lập trình và sáng tạo nội dung",
                Birthday = new DateTime(1997, 4, 10)
            },
            new PmqAccount
            {
                Id = 2, Name = "Phạm Khánh Linh",
                Email = "linh.pham@gmail.com",
                Phone = "0945556677",
                Address = "Nha Trang",
                Avatar = "/images/bn2.jpg",
                Gender = 0, Bio = "Đam mê âm nhạc và thiết kế đồ họa",
                Birthday = new DateTime(2001, 8, 12)
            },
            new PmqAccount
            {
                Id = 3, Name = "Vũ Hoàng Long",
                Email = "long.vu@gmail.com",
                Phone = "0977889900",
                Address = "Bình Dương",
                Avatar = "/images/bn3.jpg",
                Gender = 1, Bio = "Kỹ sư dữ liệu và yêu thích thể thao",
                Birthday = new DateTime(1994, 1, 25)
            },
            new PmqAccount
            {
                Id = 4, Name = "Bùi Mai Phương",
                Email = "phuong.bui@gmail.com",
                Phone = "0933221100",
                Address = "Quảng Ninh",
                Avatar = "/images/4.jpg",
                Gender = 0, Bio = "Yêu thích ẩm thực và khám phá văn hóa",
                Birthday = new DateTime(2003, 12, 5)
            }
        };
        public IActionResult PmqIndex()
        {
            ViewBag.PmqAccounts = pmqAccounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "PmqProfile")]
        public IActionResult PmqProfile(int? id)
        {
            PmqAccount pmqAccount = new PmqAccount
            {
                Id = 4,
                Name = "Bùi Mai Phương",
                Email = "phuong.bui@gmail.com",
                Phone = "0933221100",
                Address = "Quảng Ninh",
                Avatar = "/images/4.jpg",
                Gender = 0,
                Bio = "Yêu thích ẩm thực và khám phá văn hóa",
                Birthday = new DateTime(2003, 12, 5)
            };

            if (id != null)
                pmqAccount = pmqAccounts.FirstOrDefault(x => x.Id == id);

            ViewBag.PmqAccount = pmqAccount;
            return View();
        }
    }
}
