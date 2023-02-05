using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetActiveEmployees.Dtos
{
    public class GetActiveEmployeesOutput
    {
        public List<Common.Dtos.EmployeeDto> Employees { get; set; }
    }
}
