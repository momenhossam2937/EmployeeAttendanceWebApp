using EmployeeAttendanceWebApp.Application.Employee.Commands.Create.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Create
{
    public class CreateEmployeeCommand : IRequest<CreateEmployeeOutput>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
