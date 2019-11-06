using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDBFirst.Models
{
    public class EmployeeCreateModel
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên nhân viên")]
        [StringLength(maximumLength:50, MinimumLength = 10, ErrorMessage = "Tên nhân viên từ 10 đến 50 ký tự")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập số điện thoại")]
        [RegularExpression(pattern: "(09|01[2|6|8|9])+([0-9]{8})", ErrorMessage ="Số điện thoại không đúng định dạng")]
        public string PhoneNumber { get; set; }
        public int SkillID { get; set; }    
        [Required(ErrorMessage ="Bạn phải nhập số năm kinh nghiệm")]
        [Range(minimum:0, maximum:30, ErrorMessage ="Số năm kinh nghiệm từ 0 đến 30")]
        public int YearsExperience { get; set; }
    }
}
