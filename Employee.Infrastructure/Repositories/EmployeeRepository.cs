using System.Data.SqlClient;
using Employee.Domain.Entities;
using Employee.Domain.Interfaces;

namespace Employee.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<EmployeeEntity>> GetAllAsync()
        {
            var employees = new List<EmployeeEntity>();

            using var conn = new SqlConnection(_connectionString);
            await conn.OpenAsync();

            using var cmd = new SqlCommand(
                "SELECT EmployeeId, FirstName, LastName, Email, DepartmentId, IsActive FROM Employees",
                conn);

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                employees.Add(new EmployeeEntity
                {
                    EmployeeId = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    DepartmentId = reader.GetInt32(4),
                    IsActive = reader.GetBoolean(5)
                });
            }

            return employees;
        }
    }
}
