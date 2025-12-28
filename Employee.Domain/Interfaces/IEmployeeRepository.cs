using Employee.Domain.Entities;

namespace Employee.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetAllAsync();
    }
}
