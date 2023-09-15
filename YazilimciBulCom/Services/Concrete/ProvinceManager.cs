using YazilimciBulCom.Entities.Provinces;
using YazilimciBulCom.Repositories.Abstract;
using YazilimciBulCom.Services.Abstract;

namespace YazilimciBulCom.Services.Concrete
{
    public class ProvinceManager : IProvinceService
    {
        public IProvinceRepository ProvinceRepository { get; set; }

        public ProvinceManager(IProvinceRepository provinceRepository)
        {
            ProvinceRepository = provinceRepository;
        }

        public async Task<ProvinceGetByIdDto?> GetByIdAsync(int id)
        {
            Province? province = await ProvinceRepository.GetSingleAsync(province => province.Id == id);
            return new ProvinceGetByIdDto(province.Name);
        }

        public IQueryable<ProvinceListDto> GetAll()
        {
            return ProvinceRepository.GetAll().Select(x => new ProvinceListDto(x.Id, x.Number, x.Name));
        }
    }
}
