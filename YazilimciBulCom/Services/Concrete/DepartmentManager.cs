using YazilimciBulCom.Entities.Departments;
using YazilimciBulCom.Repositories.Abstract;
using YazilimciBulCom.Services.Abstract;

namespace YazilimciBulCom.Services.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        public IDepartmentRepository DepartmentRepository { get; set; }

        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            DepartmentRepository = departmentRepository;
        }


        public IQueryable<DepartmentListDto> GetAll()
        {
            return DepartmentRepository.GetAll().Select(department => new DepartmentListDto(department.Id, department.Name));
        }

        public async Task<DepartmentGetByIdDto?> GetByIdAsync(int id)
        {
            Department? department = await DepartmentRepository.GetSingleAsync(department => department.Id == id);
            return new DepartmentGetByIdDto(department.Name);
        }
    }
}
