using AutoMapper;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Create.Dtos;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create.Dtos;
using EmployeeAttendanceWebApp.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create
{
    public class CreateEmployeeAttendanceCommandHnadler : IRequestHandler<CreateEmployeeAttendanceCommand, CreateEmployeeAttendanceOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeAttendanceRepository _employeeAttendanceRepository;

        public CreateEmployeeAttendanceCommandHnadler(IMapper mapper, IEmployeeAttendanceRepository employeeAttendanceRepository)
        {
            _mapper = mapper;
           _employeeAttendanceRepository= employeeAttendanceRepository;
        }
        public async Task<CreateEmployeeAttendanceOutput> Handle(CreateEmployeeAttendanceCommand request, CancellationToken cancellationToken)
        {
            var employeeAttendance = _mapper.Map<Domain.Entities.EmployeeAttendance>(request);

            employeeAttendance.DEVDT = ((DateTimeOffset)request.DEVDT2.ToLocalTime()).ToUnixTimeSeconds();

            employeeAttendance.SRVDT = DateTime.Now;

            await _employeeAttendanceRepository.AddAsync(employeeAttendance, cancellationToken);
         
            if (await _employeeAttendanceRepository.UnitOfWork.CommitAsync(cancellationToken))
            {
                return new CreateEmployeeAttendanceOutput
                {
                    IsCreated = true,
                };
            }

            return new CreateEmployeeAttendanceOutput
            {
                IsCreated = false,
            };
        }
    }
}
