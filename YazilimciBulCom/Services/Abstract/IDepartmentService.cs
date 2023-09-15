using YazilimciBulCom.Entities.Departments;

namespace YazilimciBulCom.Services.Abstract
{
    public interface IDepartmentService
    {
        Task<DepartmentGetByIdDto?> GetByIdAsync(int id);

        IQueryable<DepartmentListDto> GetAll();
    }
}