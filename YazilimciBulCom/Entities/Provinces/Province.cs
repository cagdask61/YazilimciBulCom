using YazilimciBulCom.Entities.Common;
using YazilimciBulCom.Entities.Employees;

namespace YazilimciBulCom.Entities.Provinces
{
    public class Province : CommonEntity
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
