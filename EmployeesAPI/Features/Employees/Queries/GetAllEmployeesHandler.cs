using Employee.Domain.Entities;
using Employee.Domain.Interfaces;
using MediatR;

namespace Employee.API.Features.Employees.Queries
{
    public class GetAllEmployeesHandler
        : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
    {
        private readonly IEmployeeRepository _repository;

        public GetAllEmployeesHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EmployeeEntity>> Handle(
            GetAllEmployeesQuery request,
            CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
