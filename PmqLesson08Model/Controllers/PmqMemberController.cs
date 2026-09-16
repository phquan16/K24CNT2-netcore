using Microsoft.AspNetCore.Mvc;
using PmqLesson08Model.Models;

namespace PmqLesson08Model.Controllers
{
    public class PmqMemberController : Controller
    {
        //mock data
        private static List<PmqMember> _pmqMembers = new List<PmqMember>()
        {
            new PmqMember
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "pmq_admin",
                PmqPassWord = "123456Password@",
                PmqFullName = "Phạm Minh Quan",
                PmqEmail = "minhquan.admin@gmail.com"
            },
            new PmqMember
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "quang_user01",
                PmqPassWord = "UserPass123!",
                PmqFullName = "Trần Thị Ánh",
                PmqEmail = "anh.tran@gmail.com"
            },
            new PmqMember
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "pmq_customer",
                PmqPassWord = "CustomerPass2026!",
                PmqFullName = "Nguyễn Văn Hùng",
                PmqEmail = "hung.nguyen@yahoo.com"
            },
            new PmqMember
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "pmq_seller",
                PmqPassWord = "SellerPass#456",
                PmqFullName = "Lê Hoàng Nam",
                PmqEmail = "nam.le@hotmail.com"
            },
            new PmqMember
            {
                PmqMemberId = Guid.NewGuid().ToString(),
                PmqUserName = "pmq_member05",
                PmqPassWord = "MemberPass$789",
                PmqFullName = "Đặng Thị Mai",
                PmqEmail = "mai.dang@gmail.com"
            }
        };
        //Get: danh sachs thanfh vien
        public IActionResult Index()
        {
            return View(_pmqMembers);
        }
        [HttpGet]
        public IActionResult PmqCreate()
        {
            var member = new PmqMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult PmqCreate(PmqMember pmqMember)
        {
            pmqMember.PmqMemberId = Guid.NewGuid().ToString();
            _pmqMembers.Add(pmqMember);
            return RedirectToAction("Index");
            //return View(pmqMember);
        }
        [HttpGet]
        public IActionResult PmqEdit(string id)
        {
            var member = _pmqMembers.Where(x => x.PmqMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public IActionResult PmqEdit(string id, PmqMember pmqMember)
        {
            //pmqMember.PmqMemberId = Guid.NewGuid().ToString();
            for (int i = 0; i < _pmqMembers.Count; i++)
            {
                if (_pmqMembers[i].PmqMemberId == id )
                {
                    _pmqMembers[i].PmqUserName = pmqMember.PmqUserName;
                    _pmqMembers[i].PmqPassWord = pmqMember.PmqPassWord;
                    _pmqMembers[i].PmqFullName = pmqMember.PmqFullName;
                    _pmqMembers[i].PmqEmail = pmqMember.PmqEmail;
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult PmqDetails(string id)
        {
            var member = _pmqMembers.Where(x => x.PmqMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }
        [HttpGet]
        public IActionResult PmqDelete(string id)
        {
            var member = _pmqMembers.Where(x => x.PmqMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public IActionResult PmqDeleted(string id)
        {
            foreach (var item in _pmqMembers)
            {
                if (item.PmqMemberId.Equals(id))
                {
                    _pmqMembers.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View(PmqDelete);
        }
    }
}
