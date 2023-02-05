using EmployeeAttendanceWebApp.Application.Employee.Commands.Remove.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Remove
{
    public class RemoveEmployeeCommand : IRequest<RemoveEmployeeOutput>
    {
        public long Id { get; set; }
    }
}
