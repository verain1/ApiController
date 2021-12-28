using Microsoft.AspNetCore.Mvc;
using empService.Models;

namespace empService.Controllers
{
    // [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost("SaveEmployee")]
        public Employee CreateEmployee([FromBody] Employee employee)
        {
            return employee;
        }
    }
}