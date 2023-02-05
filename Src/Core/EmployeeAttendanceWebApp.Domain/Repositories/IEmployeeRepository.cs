using EmployeeAttendanceWebApp.Domain.Entities;
using EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EmployeeAttendanceWebApp.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee, long>
    {
        Task<List<Employee>> GetActiveEmployeesAsync(CancellationToken cancellationToken = default);
    }
}
