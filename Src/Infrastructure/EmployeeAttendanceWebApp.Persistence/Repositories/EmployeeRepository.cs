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
    public class EmployeeRepository : RepositoryBase<Employee, long>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Employee>> GetActiveEmployeesAsync(CancellationToken cancellationToken = default)
        {
            return await _entities.Where(i => i.IsActive == true).ToListAsync();
        }
    }
}
