using EmployeeAttendanceWebApp.Domain.Entities;
using EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Domain.Repositories
{
    public interface IEmployeeAttendanceDateTimeRepository 
    {
        Task<List<EmployeeAttendanceDateTime>> GetAllEmployeeAttendanceByMonth(long empId,int month);
        Task<List<EmployeeAttendanceDateTime>> GetAllEmployeeAttendanceByDate(long empId, DateTime date);

    }
}
