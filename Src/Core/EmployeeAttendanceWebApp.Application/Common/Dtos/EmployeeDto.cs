using EmployeeAttendanceWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Common.Dtos
{
    public class EmployeeDto
    {
        public long EMPID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public bool IsActive { get; set; }
        public virtual List<EmployeeAttendanceDto> EmployeeAttendances { get; set; }
    }
}
