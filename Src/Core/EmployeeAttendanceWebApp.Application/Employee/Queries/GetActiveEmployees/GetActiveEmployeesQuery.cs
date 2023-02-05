using EmployeeAttendanceWebApp.Application.Employee.Queries.GetActiveEmployees.Dtos;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetActiveEmployees
{
    public class GetActiveEmployeesQuery : IRequest<GetActiveEmployeesOutput>
    {
    }
}
