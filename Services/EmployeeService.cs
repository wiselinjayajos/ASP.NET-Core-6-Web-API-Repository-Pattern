using System.Collections.Generic;
using System.Threading.Tasks;
using HRISWebAPI.Models;
using HRISWebAPI.Repositories;

namespace HRISWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(int pageNumber, int pageSize)
        {
            return await _employeeRepository.GetAllAsync(pageNumber, pageSize);
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }
    }
}
