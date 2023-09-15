using YazilimciBulCom.Entities.Common;
using YazilimciBulCom.Entities.Employees;

namespace YazilimciBulCom.Entities.Departments
{
    public class Department : CommonEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
