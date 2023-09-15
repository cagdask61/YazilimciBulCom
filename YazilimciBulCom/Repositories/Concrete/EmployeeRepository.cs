using YazilimciBulCom.Contexts;
using YazilimciBulCom.Entities.Employees;
using YazilimciBulCom.Repositories.Abstract;

namespace YazilimciBulCom.Repositories.Concrete
{
    public class EmployeeRepository : CommonRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CommonDbContext context) : base(context)
        {
            
        }
    }
}
