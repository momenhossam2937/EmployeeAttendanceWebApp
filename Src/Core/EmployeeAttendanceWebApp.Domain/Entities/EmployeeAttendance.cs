using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Domain.Entities
{
    public class EmployeeAttendance
    {
        public int Id { get; set; }
        public long EVETLGUID { get; set; }
        public DateTime SRVDT { get; set; }
        public long DEVDT { get; set; }
        public long DEVUID { get; set; }
        public virtual Employee Employee { get; set; }
        public long EMPID { get; set; }
    }
}
