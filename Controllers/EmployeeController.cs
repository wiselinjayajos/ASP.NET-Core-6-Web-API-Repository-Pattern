using HRISWebAPI.Models;
using HRISWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRISWebAPI.Controllers
{
    [Route("hriswebapi")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// To Get All the employees with pagination and limits.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("GetEmployees")]
        public async Task<IEnumerable<Employee>> GetEmployees([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            return await _employeeService.GetAllEmployeesAsync(pageNumber, pageSize);
        }


        [HttpGet("GetEmployee")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }
    }
}
