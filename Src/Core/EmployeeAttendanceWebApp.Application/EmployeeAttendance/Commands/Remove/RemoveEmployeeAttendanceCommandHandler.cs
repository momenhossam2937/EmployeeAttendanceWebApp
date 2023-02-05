using AutoMapper;
using EmployeeAttendanceWebApp.Application.Common.Dtos;
using EmployeeAttendanceWebApp.Application.Common.Exceptions;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Remove.Dtos;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee.Dtos;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Remove.Dto;
using EmployeeAttendanceWebApp.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Remove
{
    public class RemoveEmployeeAttendanceCommandHandler : IRequestHandler<RemoveEmployeeAttendanceCommand, RemoveEmployeeAttendanceOutput>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeAttendanceRepository _employeeAttendanceRepository;
        private readonly IEmployeeAttendanceDateTimeRepository _employeeAttendanceDateTimeRepository;

        public RemoveEmployeeAttendanceCommandHandler(IMapper mapper, IEmployeeAttendanceRepository employeeAttendanceRepository, IEmployeeAttendanceDateTimeRepository employeeAttendanceDateTimeRepository)
        {
            _mapper = mapper;
            _employeeAttendanceRepository = employeeAttendanceRepository;
            _employeeAttendanceDateTimeRepository = employeeAttendanceDateTimeRepository;
        }
        public async Task<RemoveEmployeeAttendanceOutput> Handle(RemoveEmployeeAttendanceCommand request, CancellationToken cancellationToken)
        {
            var employeeAttendanceDateTimeEntity = await _employeeAttendanceDateTimeRepository.GetAllEmployeeAttendanceByDate(request.EmployeeId,request.Date);

            if (employeeAttendanceDateTimeEntity == null || employeeAttendanceDateTimeEntity.Count == 0)
            {
                throw new NotFoundException(nameof(employeeAttendanceDateTimeEntity));
            }

            var employeeAttendanceEntities = await _employeeAttendanceRepository.GetAllEmployeeAttendanceByIds(employeeAttendanceDateTimeEntity.Select(i=>i.Id.Value).ToList());

            foreach (var employeeAttendanceEntity in employeeAttendanceEntities)
            {
                await _employeeAttendanceRepository.RemoveAsync(employeeAttendanceEntity);

            }


            if (await _employeeAttendanceRepository.UnitOfWork.CommitAsync(cancellationToken))
            {
                return new RemoveEmployeeAttendanceOutput
                {
                    IsDeleted = true
                };
            }

            return new RemoveEmployeeAttendanceOutput
            {
                IsDeleted = false
            };
        }
    }
}
