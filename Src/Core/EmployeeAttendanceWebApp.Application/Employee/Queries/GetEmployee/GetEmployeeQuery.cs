using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeQuery : IRequest<GetEmployeeOutput>
    {
        public long Id { get; set; }
    }
}
