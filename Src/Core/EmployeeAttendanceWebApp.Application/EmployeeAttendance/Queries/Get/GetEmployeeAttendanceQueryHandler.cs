using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee.Dtos;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get.Dtos;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;
using EmployeeAttendanceWebApp.Domain.Repositories;
using System.Linq;
using EmployeeAttendanceWebApp.Application.Common.Dtos;
using EmployeeAttendanceWebApp.Application.Common.Exceptions;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get
{
    public class GetEmployeeAttendanceQueryHandler : IRequestHandler<GetEmployeeAttendanceQuery, GetEmployeeAttendanceOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeAttendanceDateTimeRepository _employeeAttendanceRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeAttendanceQueryHandler(IMapper mapper, IEmployeeAttendanceDateTimeRepository employeeAttendanceRepository, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeAttendanceRepository = employeeAttendanceRepository;
            _employeeRepository= employeeRepository;
        }
        public async Task<GetEmployeeAttendanceOutput> Handle(GetEmployeeAttendanceQuery request, CancellationToken cancellationToken)
        {
            var employeeExist = await _employeeRepository.GetAsync(request.EMPID);
            if(employeeExist == null)
            {
                return new GetEmployeeAttendanceOutput
                {
                
                    IsSuccess = false,
                    Error = "Employee Not Found"

                };
            }

            var emplyeeAttendances = await _employeeAttendanceRepository.GetAllEmployeeAttendanceByMonth(request.EMPID, request.Month);

            var allDaysInMonth = Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Now.Year, request.Month))
               .Select(day => new DateTime(DateTime.Now.Year, request.Month, day))
               .ToList();

            var output = new List<EmployeeAttendanceDateTimeDto>();

            foreach (var dayInMonth in allDaysInMonth)
            {
                if (!emplyeeAttendances.Select(i => i.DEVDT.Date).Contains(dayInMonth.Date))
                {
                    output.Add(new EmployeeAttendanceDateTimeDto
                    {
                        UserID = request.EMPID,
                        Date = dayInMonth.Date,
                        FirstRecordDateTime = null,
                        LastRecordDateTime = null
                    });
                }
            }
            var groupedEmployeeAttendance = emplyeeAttendances.GroupBy(i => i.DEVDT.Day).ToList();

            foreach (var employeeAttendance in groupedEmployeeAttendance)
            {
                var firstEmployeeAttendance = employeeAttendance.FirstOrDefault();

                var lastEmployeeAttendance = employeeAttendance.LastOrDefault();

                output.Add(new EmployeeAttendanceDateTimeDto
                {
                   
                    UserID = request.EMPID,
                    Date = firstEmployeeAttendance.DEVDT.Date,
                    FirstRecordDateTime = firstEmployeeAttendance.DEVDT.ToShortTimeString(),
                    LastRecordDateTime = lastEmployeeAttendance.DEVDT.ToShortTimeString()

                });
            }

            return new GetEmployeeAttendanceOutput
            {
                EmployeeAttendances = output.OrderBy(i => i.Date.Day).ToList(),
                IsSuccess = true

            };
        }
    }
}
