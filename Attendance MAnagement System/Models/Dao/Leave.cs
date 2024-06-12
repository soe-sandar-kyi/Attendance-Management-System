using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_MAnagement_System.Models.Dao
{
    [Table("Leave")]
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
        public int LeaveType { get; set; }
        [ForeignKey("Employee")]
        public string employeeId { get; set; }
    }
}
