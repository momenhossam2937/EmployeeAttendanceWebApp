using EmployeeAttendanceWebApp.Application.Employee.Commands.Update.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Update
{
    public class UpdateEmployeeCommand : IRequest<UpdateEmployeeOutput>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
