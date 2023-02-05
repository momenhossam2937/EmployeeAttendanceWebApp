using MediatR;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Remove.Dtos;
using System.Threading.Tasks;
using System.Threading;
using EmployeeAttendanceWebApp.Domain.Repositories;
using EmployeeAttendanceWebApp.Application.Common.Exceptions;

namespace EmployeeAttendanceWebApp.Application.Employee.Commands.Remove
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand, RemoveEmployeeOutput>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public RemoveEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<RemoveEmployeeOutput> Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetAsync(request.Id, cancellationToken);

            if (employee == null)
            {
                throw new NotFoundException(nameof(employee));
            }

            employee.IsActive = false;


            if (await _employeeRepository.UnitOfWork.CommitAsync(cancellationToken))
            {
                return new RemoveEmployeeOutput
                {
                    IsDeleted = true
                };
            }

            return new RemoveEmployeeOutput
            {
                IsDeleted = false
            };
        }
    }
}
