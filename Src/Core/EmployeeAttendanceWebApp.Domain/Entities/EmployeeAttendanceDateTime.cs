using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Domain.Entities
{
    public class EmployeeAttendanceDateTime
    {
        public int? Id { get; set; }
        public long EVETLGUID { get; set; }
        public DateTime SRVDT { get; set; }
        public DateTime DEVDT { get; set; }
        public long DEVUID { get; set; }
        public long EMPID { get; set; }
    }
}
