using Employee.Domain.Entities;
using MediatR;

namespace Employee.API.Features.Employees.Queries
{
    public class GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeEntity>>
    {
    }
}
