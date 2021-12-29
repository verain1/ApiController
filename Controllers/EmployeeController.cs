using Microsoft.AspNetCore.Mvc;
using empService.Models;
using empService.DTO;

namespace empService.Controllers
{
    [ApiController] //Filter
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost("SaveEmployee")]
        public EmployeeDTO CreateEmployee(EmployeeDTO employee) 
        {
            return employee;
        }
    }
}