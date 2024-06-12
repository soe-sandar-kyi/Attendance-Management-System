using Attendance_MAnagement_System.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Attendance_MAnagement_System.ViewModels
{
    public class RegisterViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public string Name { get; set; }
        public string ManagerID { get; set; }
        public string ManagerName { get; set; }
        public RoleCategory roleCategory { get; set; }

    }
}
