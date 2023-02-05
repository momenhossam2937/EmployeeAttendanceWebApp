using MediatR;
using System;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetActiveEmployees.Dtos;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;
using EmployeeAttendanceWebApp.Domain.Repositories;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees.Dtos;
using System.Collections.Generic;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetActiveEmployees
{
    public class GetActiveEmployeesQueryHandler : IRequestHandler<GetActiveEmployeesQuery, GetActiveEmployeesOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public GetActiveEmployeesQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<GetActiveEmployeesOutput> Handle(GetActiveEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepository.GetActiveEmployeesAsync(cancellationToken);

            if (employees == null)
            {
                return new GetActiveEmployeesOutput
                {
                    Employees = new List<Common.Dtos.EmployeeDto>()
                };
            }

            return new GetActiveEmployeesOutput
            {
                Employees = _mapper.Map<List<Common.Dtos.EmployeeDto>>(employees)
            };
        }
    }
}
