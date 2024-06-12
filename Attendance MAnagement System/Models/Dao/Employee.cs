using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Attendance_MAnagement_System.Data.Enum;

namespace Attendance_MAnagement_System.Models.Dao
{
    [Table("Employee")]
    public class Employee : IdentityUser
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime DOB { get; set; }
        public string ManagerId { get; set; }
        public string ManagerName { get; set; }
        public RoleCategory role { get; set; }

    }
}
