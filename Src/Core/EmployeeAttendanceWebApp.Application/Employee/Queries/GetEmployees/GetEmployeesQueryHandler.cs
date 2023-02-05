using AutoMapper;
using EmployeeAttendanceWebApp.Application.Common.Dtos;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees.Dtos;
using EmployeeAttendanceWebApp.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, GetEmployeesOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeesQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<GetEmployeesOutput> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepository.GetListAsync(cancellationToken);

            if (employees == null)
            {
                return new GetEmployeesOutput
                {
                    Employees = new List<Common.Dtos.EmployeeDto>()
                };
            }

            return new GetEmployeesOutput
            {
                Employees = _mapper.Map<List<Common.Dtos.EmployeeDto>>(employees)
            };
        }
    }
}
