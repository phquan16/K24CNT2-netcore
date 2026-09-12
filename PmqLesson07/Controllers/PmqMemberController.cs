using Microsoft.AspNetCore.Mvc;
using PmqLesson07.Models.DataModels;

namespace PmqLesson07.Controllers
{
    public class PmqMemberController : Controller
    {
        protected static List<PmqMember> _member = new List<PmqMember>()
        {
            new()
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "nguyenvana",
                PmqPassword = "$2a$12$e8N8yQe2Z8.xH4fF3Kj1e.5v/7G9wX0Y1Z2A3B4C5D6E7F8G9H0I",
                PmqFullName = "Nguyễn Văn An",
                PmqEmail = "an.nguyen@example.com"
            },
            new()
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "tranbibich",
                PmqPassword = "$2a$12$k9L7mN6oP5.qR4sT3uV2w.1x/9Y8zA7B6C5D4E3F2G1H0I9J8K7",
                PmqFullName = "Trần Thị Bích",
                PmqEmail = "bich.tran@example.com"
            },
            new()
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "lehoangcuong",
                PmqPassword = "$2a$12$a1B2c3D4e5.F6g7H8i9J0.1k/2L3m4N5o6P7q8R9s0T1U2V3W4",
                PmqFullName = "Lê Hoàng Cường",
                PmqEmail = "cuong.le@example.com"
            },
            new()
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "phamthuha",
                PmqPassword = "$2a$12$z9Y8x7W6v5.U4t3S2r1Q0.9p/8O7n6M5l4K3j2I1H0G9F8E7D6",
                PmqFullName = "Phạm Thu Hà",
                PmqEmail = "ha.pham@example.com"
            },
            new()
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "hoangminhdung",
                PmqPassword = "$2a$12$m1N2O3p4Q5.r6S7t8U9v0.1w/2X3y4Z5a6B7c8D9e0F1G2H3I4",
                PmqFullName = "Hoàng Minh Dũng",
                PmqEmail = "dung.hoang@example.com"
            }
        };

        public IActionResult Index()
        {
            return View(_member);
        }

        public IActionResult GetMembers()
        {
            ViewBag.Members = _member;
            return View();
        }

        public IActionResult GetMember()
        {
            var member = new PmqMember
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "Ph Quan",
                PmqPassword = "0987667",
                PmqFullName = "Pham Minh Quan",
                PmqEmail = "PhQuan@gmail.com"
            };

            return View(member);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PmqMember member)
        {
            if (ModelState.IsValid)
            {
                member.PmqMemberId = Guid.NewGuid().ToString();
                _member.Add(member);
                // Thêm xong quay lại danh sách Index
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }
    }
}