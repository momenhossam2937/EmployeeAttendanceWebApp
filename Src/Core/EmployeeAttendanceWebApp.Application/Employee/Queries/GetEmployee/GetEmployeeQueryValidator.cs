using EmployeeAttendanceWebApp.Application.Employee.Commands.Update;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeQueryValidator : AbstractValidator<GetEmployeeQuery>
    {
        public GetEmployeeQueryValidator()
        {
            RuleFor(c => c.Id)
        .NotEmpty().WithMessage("Employee Id Is Required");
        }
    }
}
