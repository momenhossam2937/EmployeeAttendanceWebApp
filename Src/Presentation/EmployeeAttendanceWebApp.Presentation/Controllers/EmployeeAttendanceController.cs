using EmployeeAttendanceWebApp.Application.Employee.Commands.Create;
using EmployeeAttendanceWebApp.Application.Employee.Commands.Remove;
using EmployeeAttendanceWebApp.Application.Employee.Queries.GetEmployee;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Create;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Commands.Remove;
using EmployeeAttendanceWebApp.Application.EmployeeAttendance.Queries.Get;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeAttendanceWebApp.Presentation.Controllers
{
    [Route("api/attendance/[action]")]
    [ApiController]
    public class EmployeeAttendanceController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeAttendanceCommand command)
        {
            var output = await Mediator.Send(command);
            return Ok(output);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Get([FromQuery] GetEmployeeAttendanceQuery query)
        {
            var output = await Mediator.Send(query);
            return Ok(output);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Remove([FromBody] RemoveEmployeeAttendanceCommand command)
        {
            var output = await Mediator.Send(command);
            return Ok(output);
        }
    }
}
