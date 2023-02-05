using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Common.Dtos
{
    public class EmployeeAttendanceDto
    {
        public long EVETLGUID { get; set; }
        public DateTime SRVDT { get; set; }
        public long DEVDT { get; set; }
        public long DEVUID { get; set; }
    }
}
