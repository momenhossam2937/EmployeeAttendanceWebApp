using EmployeeAttendanceWebApp.Application.Employee.Commands.Update;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Remove
{
    public class RemoveEmployeeCommandValidator : AbstractValidator<RemoveEmployeeCommand>
    {
        public RemoveEmployeeCommandValidator()
        {
            RuleFor(c => c.Id)
           .NotEmpty().WithMessage("Employee Id Is Required");
        }
    }
}
