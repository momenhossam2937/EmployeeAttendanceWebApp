using EmployeeAttendanceWebApp.Domain.Repositories;
using EmployeeAttendanceWebApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceWebApp.Persistence.Common
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(BuildDbContextOptions);
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeAttendanceRepository, EmployeeAttendanceRepository>();
            services.AddScoped<IEmployeeAttendanceDateTimeRepository, EmployeeAttendanceDateTimeRepository>();
            return services;
        }

        private static void BuildDbContextOptions(IServiceProvider serviceProvider, DbContextOptionsBuilder options)
        {
            var connString = @"Server=LAPTOP-9UKCERNT\SQLEXPRESS;Database=EmployeeDB;Integrated Security=True;MultipleActiveResultSets=False;";

            options.UseSqlServer(connString);
        }
    }
}
