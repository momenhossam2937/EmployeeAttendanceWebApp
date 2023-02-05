using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.Common.Dtos
{
    public class EmployeeAttendanceDateTimeDto
    {
        public long UserID { get; set; }
        public DateTime Date { get; set; }
        public string FirstRecordDateTime { get; set; }
        public string LastRecordDateTime { get; set; }
    }
}
