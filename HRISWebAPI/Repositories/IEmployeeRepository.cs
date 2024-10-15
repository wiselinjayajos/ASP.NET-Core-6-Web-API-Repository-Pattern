using HRISWebAPI.Models;
namespace HRISWebAPI.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync(int pageNumber, int pageSize);
        Task<Employee> GetByIdAsync(int id);
    }
}
