using EmployeeAttendanceWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EmployeeAttendanceWebApp.Persistence.Configurations
{
    public class EmployeeAttendanceConfiguration : IEntityTypeConfiguration<EmployeeAttendance>
    {
        public void Configure(EntityTypeBuilder<EmployeeAttendance> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.EVETLGUID).HasMaxLength(255).IsRequired();
            builder.Property(bc => bc.EMPID).IsRequired();
        

        }
    }
}
