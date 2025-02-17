namespace CompanyAPI.DTOs
{
    public class EmployeesDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string DepartmentName { get; set; }
    }
}

