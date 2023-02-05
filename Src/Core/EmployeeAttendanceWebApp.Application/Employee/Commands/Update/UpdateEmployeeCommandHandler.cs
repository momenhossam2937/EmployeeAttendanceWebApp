using EmployeeAttendanceWebApp.Application.Employee.Commands.Create.Dtos;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Create;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Update.Dtos;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;
using EmployeeAttendanceWebApp.Domain.Repositories;
using EmployeeAttendanceWebApp.Application.Common.Exceptions;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Update
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, UpdateEmployeeOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeCommandHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<UpdateEmployeeOutput> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetAsync(request.Id, cancellationToken);

            if (employee == null)
            {
                throw new NotFoundException(nameof(employee));
            }

            _mapper.Map(request, employee);

            if (await _employeeRepository.UnitOfWork.CommitAsync(cancellationToken))
            {
                return new UpdateEmployeeOutput
                {
                    IsUpdated = true,
                };
            }

            return new UpdateEmployeeOutput
            {
                IsUpdated = false,
            };
        }
    }
}
