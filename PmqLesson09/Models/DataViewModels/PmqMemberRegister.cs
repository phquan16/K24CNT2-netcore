using Microsoft.AspNetCore.Cors;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PmqLesson09.Models.DataViewModels
{
    ///<summary>
    /// Data Annotation - Validation
    ///</summary>
    public class PmqMemberRegister
    {
        public int PmqMemberId { get; set; }
        [DisplayName("Ten dangw nhap")]
        [Required(ErrorMessage = "Ten dang nhap khong de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoản 2 - 20 ký tự")]
        public string PmqUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string PmqPassword { get; set; }
        public string PmqEmail { get; set; }
        public string PmqPhoneNumber { get; set; }
        public string PmqFullName { get; set; }
        public string PmqBirthday { get; set; }
    }
}
