namespace YazilimciBulCom.Entities.Employees
{
    public class EmployeeGetByIdDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public string ProvinceName { get; set; }
        public string DepartmentName { get; set; }
        public int SalaryExpectation { get; set; }
        public bool Gender { get; set; }
        public short Age { get; set; }
        public string Name { get; set; }
    }
}
