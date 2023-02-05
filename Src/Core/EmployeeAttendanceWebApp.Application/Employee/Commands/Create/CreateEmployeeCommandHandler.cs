using AutoMapper;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Create.Dtos;
using EmployeeAttendanceWebApp.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Create
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, CreateEmployeeOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeCommandHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<CreateEmployeeOutput> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Domain.Entities.Employee>(request);

            employee.IsActive = true;

            await _employeeRepository.AddAsync(employee, cancellationToken);

            if (await _employeeRepository.UnitOfWork.CommitAsync(cancellationToken))
            {
                return new CreateEmployeeOutput
                {
                    IsCreated = true,
                };
            }

            return new CreateEmployeeOutput
            {
                IsCreated = false,
            };
        }
    }
}
