using EmployeeAttendanceWebApp.Domain.Entities;
using EmployeeAttendanceWebApp.Domain.Repositories;
using EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Persistence.Repositories
{
    public class EmployeeAttendanceDateTimeRepository : IEmployeeAttendanceDateTimeRepository
    {
        private readonly ApplicationDbContext _context;

        protected readonly DbSet<EmployeeAttendanceDateTimeRepository> _entities;

        public EmployeeAttendanceDateTimeRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<EmployeeAttendanceDateTimeRepository>();
        }

        public async Task<List<Domain.Entities.EmployeeAttendanceDateTime>> GetAllEmployeeAttendanceByMonth(long empId, int month)
        {
            
           return await _context.EmployeeAttendanceDateTime.Where(i => i.EMPID == empId && i.DEVDT.Month == month).ToListAsync();
        }

        public async Task<List<EmployeeAttendanceDateTime>> GetAllEmployeeAttendanceByDate(long empId, DateTime date)
        {
            return await _context.EmployeeAttendanceDateTime.Where(i => i.EMPID == empId && i.DEVDT.Date == date).ToListAsync();
        }
    }
}
