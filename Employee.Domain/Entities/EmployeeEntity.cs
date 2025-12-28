namespace Employee.Domain.Entities
{
    public class EmployeeEntity
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int DepartmentId { get; set; }

        public bool IsActive { get; set; }
    }
}
