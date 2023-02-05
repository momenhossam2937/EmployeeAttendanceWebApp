using EmployeeAttendanceWebApp.Domain.Entities;
using EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Domain.Repositories
{
    public interface IEmployeeAttendanceRepository : IRepository<EmployeeAttendance, int>
    {
        Task<List<EmployeeAttendance>> GetAllEmployeeAttendanceByIds(List<int> ids);

    }
}
