using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Domain.Entities
{
    public class Employee
    {
        public long EMPID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public bool IsActive { get; set; }
        public virtual List<EmployeeAttendance> EmployeeAttendances { get; set; }
    }
}
