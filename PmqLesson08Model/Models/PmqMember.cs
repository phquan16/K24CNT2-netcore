using Microsoft.AspNetCore.Cors;
using System.ComponentModel;

namespace PmqLesson08Model.Models
{
    public class PmqMember
    {
        public String PmqMemberId { get; set; }
        public string PmqUserName { get; set; }
        public string PmqPassWord { get; set; }
        [DisplayName("Họ và tên")]
        public string PmqFullName { get; set; }
        public string PmqEmail { get; set; }
    }
}
