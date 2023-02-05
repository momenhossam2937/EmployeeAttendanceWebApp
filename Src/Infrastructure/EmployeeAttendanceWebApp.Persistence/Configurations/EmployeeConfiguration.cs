using EmployeeAttendanceWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Persistence.Configurations
{
    public  class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EMPID);
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired();
            builder.Property(bc => bc.Email).IsRequired();
            builder.Property(bc => bc.PhoneNo).IsRequired();
            builder.HasMany(bc => bc.EmployeeAttendances)
            .WithOne(b => b.Employee)
            .HasForeignKey(bc => bc.EMPID)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
