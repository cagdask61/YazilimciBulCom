using YazilimciBulCom.Entities.Employees;

namespace YazilimciBulCom.Models
{
    public class ProfileModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public string? Picture { get; set; }
        public string? NickName { get; set; }
        public string? Email { get; set; }
        public EmployeeGetByNameDto? EmployeeGetByNameDto { get; set; }
    }
}
