using EmployeeAttendanceWebApp.Application.Employee.Commands.Create.Dtos;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create
{
    public class CreateEmployeeAttendanceCommand : IRequest<CreateEmployeeAttendanceOutput>
    {
        public long EVETLGUID { get; set; }
        public long DEVUID { get; set; }
        public long EMPID { get; set; }
        public DateTime DEVDT { get; set; }
    }
}
