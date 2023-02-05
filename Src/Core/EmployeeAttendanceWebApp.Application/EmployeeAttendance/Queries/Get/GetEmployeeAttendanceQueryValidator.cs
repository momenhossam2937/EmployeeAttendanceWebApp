using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get
{
    public class GetEmployeeAttendanceQueryValidator : AbstractValidator<GetEmployeeAttendanceQuery>
    {
        public GetEmployeeAttendanceQueryValidator()
        {
            RuleFor(c => c.Month)
             .NotEmpty().WithMessage("Month Is Required");
        }
    }
}
