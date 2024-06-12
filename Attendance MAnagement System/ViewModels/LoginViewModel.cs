using Attendance_MAnagement_System.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Attendance_MAnagement_System.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "Employee Id is required")]
        public string EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public RoleCategory role { get; set; }
    }
}
