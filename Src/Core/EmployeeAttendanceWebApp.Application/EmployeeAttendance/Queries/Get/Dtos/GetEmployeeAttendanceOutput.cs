using EmployeeAttendanceWebApp.Application.Common.Dtos;
using EmployeeAttendanceWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get.Dtos
{
    public class GetEmployeeAttendanceOutput
    {
        public List<EmployeeAttendanceDateTimeDto> EmployeeAttendances { get; set; }

        public bool IsSuccess { get; set; }
        public string Error { get; set; }
    }
}
