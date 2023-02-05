using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee.Dtos;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get
{
    public class GetEmployeeAttendanceQuery : IRequest<GetEmployeeAttendanceOutput>
    {
        public int Month { get; set; }
        public long EMPID { get; set; }
    }
}
