using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create.Dtos;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Remove.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Remove
{
    public class RemoveEmployeeAttendanceCommand : IRequest<RemoveEmployeeAttendanceOutput>
    {
        public long EmployeeId { get; set; }
        public DateTime Date { get; set; }
    }
}
