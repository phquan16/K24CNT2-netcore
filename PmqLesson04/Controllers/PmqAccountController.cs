using Microsoft.AspNetCore.Mvc;
using PmqLesson04.Models;
using System.Xml.Serialization;

namespace PmqLesson04.Controllers
{
    public class PmqAccountController : Controller
    {
        private readonly List<PmqAccount> pmqAccounts = new()
        { 
            new()
            {
                Id = 1,
                Name = "Yasuo",
                Email = "yasuo.ionia@leagueoflegends.com",
                Phone = "0901234501",
                Avatar = "/Images/1.jpg",
                Address = "Làng Vô Danh, Ionia",
                Bio = "Một kiếm sĩ kiêu hãnh với kỹ năng điều khiển phong thuật, bị buộc tội vô căn cứ về cái chết của sư phụ.",
                Gender = 1,
                Birthday = new DateTime(2013, 12, 13)
            },
            new()
            {
                Id = 2,
                Name = "Ahri",
                Email = "ahri.vastaya@leagueoflegends.com",
                Phone = "0901234502",
                Avatar = "/Images/2.jpg",
                Address = "Khu Rừng Linh Hồn, Ionia",
                Bio = "Hồ nữ Vastaya kết nối tự nhiên với ma thuật của Runeterra, có khả năng thao túng cảm xúc của mục tiêu.",
                Gender = 0,
                Birthday = new DateTime(2011, 12, 14)
            },
            new()
            {
                Id = 3,
                Name = "Jinx",
                Email = "jinx.zaun@leagueoflegends.com",
                Phone = "0901234503",
                Avatar = "/Images/3.jpg",
                Address = "Thành Phố Ngầm Zaun",
                Bio = "Tội phạm điên rồ và vô chính phủ đến từ Zaun, thích tàn phá với những món đồ chơi cháy nổ.",
                Gender = 0,
                Birthday = new DateTime(2013, 10, 10)
            },
            new()
            {
                Id = 4,
                Name = "Garen",
                Email = "garen.demacia@leagueoflegends.com",
                Phone = "0901234504",
                Avatar = "/Images/4.jpg",
                Address = "Thành Phố Demacia",
                Bio = "Lãnh đạo quả cảm của Đội Tiên Phong Tiên Phong Đêm, chiến đấu vì sự bình yên và vinh quang của Demacia.",
                Gender = 1,
                Birthday = new DateTime(2010, 4, 27)
            },
            new()
            {
                Id = 5,
                Name = "Lux",
                Email = "lux.crownguard@leagueoflegends.com",
                Phone = "0901234505",
                Avatar = "/Images/5.jpg",
                Address = "Đại Tộc Crownguard, Demacia",
                Bio = "Pháp sư ánh sáng trẻ tuổi bí mật sở hữu ma thuật hùng mạnh trong một vương quốc cấm đoán ma thuật.",
                Gender = 0,
                Birthday = new DateTime(2010, 10, 19)
            },
            new()
            {
                Id = 6,
                Name = "Thresh",
                Email = "thresh.shadowisles@leagueoflegends.com",
                Phone = "0901234506",
                Avatar = "/Images/6.jpg",
                Address = "Quần Đảo Bóng Đêm",
                Bio = "Cai ngục tàn nhẫn dùng lồng đèn ma quái để giam cầm và hành hạ linh hồn các nạn nhân vĩnh viễn.",
                Gender = 2,
                Birthday = new DateTime(2013, 1, 23)
            }
        }; 
        public IActionResult PmqIndex()
        {
            ViewBag.PmqAccounts = pmqAccounts;
            return View();
        }
        [Route("Ho-So-Cua-Toi", Name = "PmqProfile")]
        public IActionResult PmqProfile(int? id)
        {
            PmqAccount pmqAccount = new PmqAccount()
            {
                Id = 1,
                Name = "Yasuo",
                Email = "yasuo.ionia@leagueoflegends.com",
                Phone = "0901234501",
                Avatar = "/Images/1.jpg",
                Address = "Làng Vô Danh, Ionia",
                Bio = "Một kiếm sĩ kiêu hãnh với kỹ năng điều khiển phong thuật, bị buộc tội vô căn cứ về cái chết của sư phụ.",
                Gender = 1,
                Birthday = new DateTime(2013, 12, 13)
            };
            if (id!=null)
                pmqAccount = pmqAccounts.FirstOrDefault(x => x.Id == id);

            ViewBag.PmqAccount = pmqAccount;
            return View();
        }
    }
}
