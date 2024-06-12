using Attendance_MAnagement_System.Models.Dao;

namespace Attendance_MAnagement_System.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllUsers();
        Task<Employee> GetUserById(string id);
        bool Add(Employee user);
        bool Update(Employee user);
        bool Delete(Employee user);
        bool Save();
    }
}
