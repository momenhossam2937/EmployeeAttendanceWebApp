using EmployeeAttendanceWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Persistence.Configurations
{
    public class EmployeeAttendanceDateTimeConfiguration : IEntityTypeConfiguration<EmployeeAttendanceDateTime>
    {
        public void Configure(EntityTypeBuilder<EmployeeAttendanceDateTime> builder)
        {
            builder.HasNoKey();
        }
    }
}
