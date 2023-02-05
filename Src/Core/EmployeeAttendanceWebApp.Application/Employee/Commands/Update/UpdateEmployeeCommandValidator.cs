using EmployeeAttendanceWebApp.Application.Common.Constants;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Update
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(c => c.Id)
             .NotEmpty().WithMessage("Employee Id Is Required");
            RuleFor(c => c.Name)
              .NotEmpty().WithMessage("Employee Name Is Required")
              .MaximumLength(50);
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email Is Required")
                .Matches(Constants.EMAIL_PATTERN).WithMessage("Please Enter Valid Email");
            RuleFor(c => c.Phone).NotEmpty().WithMessage("Phone Number Is Required");
        }
    }
}
