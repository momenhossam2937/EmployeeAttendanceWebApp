using EmployeeAttendanceWebApp.Application.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees.Dtos
{
    public class GetEmployeesOutput
    {
        public List<Common.Dtos.EmployeeDto> Employees { get; set; }
    }
}
