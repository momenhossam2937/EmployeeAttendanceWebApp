using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Remove
{
    public class RemoveEmployeeAttendanceCommandValidator : AbstractValidator<RemoveEmployeeAttendanceCommand>
    {
        public RemoveEmployeeAttendanceCommandValidator()
        {
            RuleFor(c => c.EmployeeId)
            .NotEmpty().GreaterThan(0).WithMessage("Id Is Required");
        }
    }
}
