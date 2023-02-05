using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees
{
    public class GetEmployeesQuery: IRequest<GetEmployeesOutput>
    {
    }
}
