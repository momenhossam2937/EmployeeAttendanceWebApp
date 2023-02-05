using EmployeeAttendanceWebApp.Application.Employee.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create
{
    public class CreateEmployeeAttendanceCommandValidator : AbstractValidator<CreateEmployeeAttendanceCommand>
    {
        public CreateEmployeeAttendanceCommandValidator()
        {
            RuleFor(c => c.EMPID)
              .NotEmpty().GreaterThan(0).WithMessage("Employee Is Required");


            RuleFor(c => c.EVETLGUID)
            .NotEmpty().GreaterThan(0).WithMessage("EVETLGUID Is Required");
        }
    }
}
