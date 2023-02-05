using EmployeeAttendanceWebApp.Domain.Entities;
using EmployeeAttendanceWebApp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Persistence.Repositories
{
    public class EmployeeAttendanceRepository : RepositoryBase<EmployeeAttendance, int>, IEmployeeAttendanceRepository
    {
        public EmployeeAttendanceRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<EmployeeAttendance>> GetAllEmployeeAttendanceByIds(List<int> ids)
        {
           return await  _entities.Where(r => ids.Contains(r.Id)).ToListAsync();
        }
    }
}
