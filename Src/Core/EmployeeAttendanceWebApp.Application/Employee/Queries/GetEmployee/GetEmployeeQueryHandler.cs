using AutoMapper;
using EmployeeAttendanceWebApp.Application.Common.Dtos;
using EmployeeAttendanceWebApp.Application.Common.Exceptions;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee.Dtos;
using EmployeeAttendanceWebApp.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, GetEmployeeOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
    
        public async Task<GetEmployeeOutput> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            if(request ==null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            
            var employee = await _employeeRepository.GetAsync(request.Id, cancellationToken);

            if (employee == null)
            {
                throw new NotFoundException(nameof(employee));
            }

            return new GetEmployeeOutput
            {
                Employee = _mapper.Map<EmployeeDto>(employee),
            };
        }
    }
}
