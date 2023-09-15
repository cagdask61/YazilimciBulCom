using YazilimciBulCom.Contexts;
using YazilimciBulCom.Entities.Provinces;
using YazilimciBulCom.Repositories.Abstract;

namespace YazilimciBulCom.Repositories.Concrete
{
    public class ProvinceRepository : CommonRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(CommonDbContext context) : base(context)
        {

        }
    }
}