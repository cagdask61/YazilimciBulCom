using YazilimciBulCom.Contexts;
using YazilimciBulCom.Entities.Departments;
using YazilimciBulCom.Repositories.Abstract;

namespace YazilimciBulCom.Repositories.Concrete
{
    public class DepartmentRepository : CommonRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CommonDbContext context):base(context)
        {           
        }
    }
}
