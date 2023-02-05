using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository;
using EmployeeAttendanceWebApp.Domain.Entities;

namespace EmployeeAttendanceWebApp.Persistence
{
    public class ApplicationDbContext:DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
        public DbSet<EmployeeAttendanceDateTime> EmployeeAttendanceDateTime { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EMPID = 1234,
                Email = "test@test.com",
                IsActive = true,
                Name = "user",
                PhoneNo = "123456"
            });

            modelBuilder.Entity<EmployeeAttendance>().HasData(
                   new EmployeeAttendance
                   {
                       Id = 1,
                       EVETLGUID = 846,
                       DEVDT = 1672633967,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 02, 08, 32, 52),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 2,
                       EVETLGUID = 1518,
                       DEVDT = 1672662587,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 02, 16, 29, 51),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 3,
                       EVETLGUID = 1971,
                       DEVDT = 1672716474,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 03, 07, 27, 59),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 4,
                       EVETLGUID = 2676,
                       DEVDT = 1672745281,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 03, 15, 28, 01),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 5,
                       EVETLGUID = 4369,
                       DEVDT = 1672805230,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 04, 10, 14, 40),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 6,
                       EVETLGUID = 5026,
                       DEVDT = 1672836346,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 04, 16, 45, 48),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 7,
                       EVETLGUID = 5488,
                       DEVDT = 1672892904,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 05, 08, 28, 25),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 8,
                       EVETLGUID = 5968,
                       DEVDT = 1672921687,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 05, 16, 28, 09),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 9,
                       EVETLGUID = 7326,
                       DEVDT = 1673238788,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 09, 08, 33, 13),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 10,
                       EVETLGUID = 7830,
                       DEVDT = 1673267481,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 09, 16, 31, 26),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 11,
                       EVETLGUID = 8309,
                       DEVDT = 1673325481,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 10, 08, 38, 06),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 12,
                       EVETLGUID = 8310,
                       DEVDT = 1673331966,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 10, 10, 21, 06),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 13,
                       EVETLGUID = 8311,
                       DEVDT = 1673334916,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 10, 11, 15, 16),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 14,
                       EVETLGUID = 8312,
                       DEVDT = 1673343946,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 10, 13, 45, 46),
                       EMPID = 1234
                   },
                   new EmployeeAttendance
                   {
                       Id = 15,
                       EVETLGUID = 8313,
                       DEVDT = 1673527118,
                       DEVUID = 939265762,
                       SRVDT = new DateTime(2023, 01, 10, 16, 38, 38),
                       EMPID = 1234
                   }
                   );
        }


        public async Task<bool> CommitAsync(CancellationToken cancellationToken = default)
        {
            var result = await SaveChangesAsync(cancellationToken);

            return result > 0;
        }

    }
}
