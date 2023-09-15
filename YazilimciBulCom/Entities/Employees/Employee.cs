using YazilimciBulCom.Entities.Common;
using YazilimciBulCom.Entities.Departments;
using YazilimciBulCom.Entities.Provinces;

namespace YazilimciBulCom.Entities.Employees
{
    public class Employee : CommonEntity
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int ProvinceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public int SalaryExpectation { get; set; }
        public bool Gender { get; set; }
        public short Age { get; set; }

        public virtual Department Department { get; set; }
        public virtual Province Province { get; set; }
    }
}
