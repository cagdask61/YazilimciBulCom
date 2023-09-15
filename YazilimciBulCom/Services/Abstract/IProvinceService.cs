
using YazilimciBulCom.Entities.Provinces;

namespace YazilimciBulCom.Services.Abstract
{
    public interface IProvinceService
    {
        Task<ProvinceGetByIdDto?> GetByIdAsync(int id);
        IQueryable<ProvinceListDto> GetAll();
    }
}
