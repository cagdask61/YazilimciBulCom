using YazilimciBulCom.Entities.Employees;

namespace YazilimciBulCom.Services.Abstract
{
    public interface IEmployeeService
    {
        Task<EmployeeGetByIdDto> GetByIdAsync(int id);
        Task<EmployeeGetByNameDto?> GetByNameAsync(string name);

        IQueryable<EmployeeListDto> GetAll();
        IQueryable<EmployeeListDto> GetAllByFilter(int provinceId, int departmentId);

        Task AddAsync(CreateEmployee employee);
        Task UpdateAsync(UpdateEmployee employee);
        Task DeleteAsync(string name);
    }
}