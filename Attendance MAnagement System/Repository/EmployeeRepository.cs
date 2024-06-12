using Attendance_MAnagement_System.Data;
using Attendance_MAnagement_System.Interfaces;
using Attendance_MAnagement_System.Models.Dao;
using Microsoft.EntityFrameworkCore;

namespace Attendance_MAnagement_System.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public bool Add(Employee user)
        {
            _context.Add(user);
            return Save();
        }

        public bool Delete(Employee user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllUsers()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetUserById(string id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Employee user)
        {
            _context.Update(user);
            return Save();
        }
    }
}
