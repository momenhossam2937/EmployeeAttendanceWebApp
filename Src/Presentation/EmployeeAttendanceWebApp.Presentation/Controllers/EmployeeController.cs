using EmployeeAttendanceWebApp.Application.Employee.Commands.Create;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Remove;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Update;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetActiveEmployees;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Presentation.Controllers
{
    [Route("api/employee/[action]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeCommand command)
        {
            var output = await Mediator.Send(command);
            return Ok(output);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Update([FromBody] UpdateEmployeeCommand command)
        {
            var output = await Mediator.Send(command);
            return Ok(output);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Remove([FromBody] RemoveEmployeeCommand command)
        {
            var output = await Mediator.Send(command);
            return Ok(output);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAll([FromQuery] GetEmployeesQuery query)
        {
            var output = await Mediator.Send(query);
            return Ok(output);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetActiveEmployees([FromQuery]GetActiveEmployeesQuery query)
        {
            var output = await Mediator.Send(query);
            return Ok(output);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Get([FromQuery] GetEmployeeQuery query)
        {
            var output = await Mediator.Send(query);
            return Ok(output);
        }
    }
}
