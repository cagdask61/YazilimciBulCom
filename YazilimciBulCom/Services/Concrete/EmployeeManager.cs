using Microsoft.EntityFrameworkCore;
using YazilimciBulCom.Entities.Departments;
using YazilimciBulCom.Entities.Employees;
using YazilimciBulCom.Entities.Provinces;
using YazilimciBulCom.Repositories.Abstract;
using YazilimciBulCom.Services.Abstract;

namespace YazilimciBulCom.Services.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeRepository EmployeeRepository { get; set; }
        private IProvinceService ProvinceService { get; set; }
        private IDepartmentService DepartmentService { get; set; }
        public EmployeeManager(IEmployeeRepository employeeRepository, IProvinceService provinceService, IDepartmentService departmentService)
        {
            EmployeeRepository = employeeRepository;
            ProvinceService = provinceService;
            DepartmentService = departmentService;
        }

        public async Task<EmployeeGetByIdDto> GetByIdAsync(int id)
        {
            Employee employee = await EmployeeRepository.GetSingleAsync(employee => employee.Id == id);
            ProvinceGetByIdDto provinceGetByIdDto = await ProvinceService.GetByIdAsync(employee.ProvinceId);
            DepartmentGetByIdDto departmentGetByIdDto = await DepartmentService.GetByIdAsync(employee.DepartmentId);

            return new EmployeeGetByIdDto()
            {
                DepartmentName = departmentGetByIdDto.Name,
                ProvinceName = provinceGetByIdDto.Name,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Description = employee.Description,
                Gender = employee.Gender,
                PhoneNumber = employee.PhoneNumber,
                PhotoUrl = employee.PhotoUrl,
                SalaryExpectation = employee.SalaryExpectation,
                Age = employee.Age,
                Name = employee.Name,
            };
        }

        public IQueryable<EmployeeListDto> GetAll()
        {
            IQueryable<Employee> employees = EmployeeRepository.GetAll(include: queryable => queryable.Include(employee => employee.Department).Include(employee => employee.Province));

            return employees.Select(employee => new EmployeeListDto()
            {
                EmployeeId = employee.Id,
                DepartmentName = employee.Department.Name,
                ProvinceName = employee.Province.Name,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhotoUrl = employee.PhotoUrl,
            });
        }

        public IQueryable<EmployeeListDto> GetAllByFilter(int provinceId, int departmentId)
        {
            IQueryable<Employee>? _employees = Enumerable.Empty<Employee>().AsQueryable();

            // refactor
            if (provinceId == 0 && departmentId != 0)
            {
                _employees = EmployeeRepository.GetAll(
                 include: queryable => queryable.Include(employee => employee.Department).Include(employee => employee.Province),
                 filter: employee => employee.DepartmentId == departmentId);
            }
            else if (departmentId == 0 && provinceId != 0)
            {
                _employees = EmployeeRepository.GetAll(
                 include: queryable => queryable.Include(employee => employee.Department).Include(employee => employee.Province),
                 filter: employee => employee.ProvinceId == provinceId);
            }
            else if (departmentId != 0 && provinceId != 0)
            {
                _employees = EmployeeRepository.GetAll(
                 include: queryable => queryable.Include(employee => employee.Department).Include(employee => employee.Province),
                 filter: employee => employee.ProvinceId == provinceId && employee.DepartmentId == departmentId);
            }
            else
            {
                _employees = _employees = EmployeeRepository.GetAll(
                 include: queryable => queryable.Include(employee => employee.Department).Include(employee => employee.Province));
            }


            return _employees.Select(employee => new EmployeeListDto()
            {
                EmployeeId = employee.Id,
                DepartmentName = employee.Department.Name,
                ProvinceName = employee.Province.Name,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhotoUrl = employee.PhotoUrl,
            });

        }

        public async Task AddAsync(CreateEmployee employee)
        {
            if (!EmployeeRepository.GetAll(filter: e => e.Name == employee.Name).Any())
            {
                await EmployeeRepository.AddAsync(new Employee()
                {
                    DepartmentId = employee.DepartmentId,
                    ProvinceId = employee.ProvinceId,
                    Name = employee.Name,
                    Age = employee.Age,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    PhotoUrl = employee.PhotoUrl,
                    Gender = employee.Gender,
                    PhoneNumber = employee.PhoneNumber,
                    SalaryExpectation = employee.SalaryExpectation,
                    Email = employee.Email,
                    Description = employee.Description,
                });
            }
        }

        public async Task<EmployeeGetByNameDto?> GetByNameAsync(string name)
        {
            EmployeeGetByNameDto? employeeGetByNameDto = null;
            Employee? employee = await EmployeeRepository.GetSingleAsync(employee => employee.Name == name);

            if (employee != null)
            {
                ProvinceGetByIdDto? provinceGetByIdDto = await ProvinceService.GetByIdAsync(employee.ProvinceId);
                DepartmentGetByIdDto? departmentGetByIdDto = await DepartmentService.GetByIdAsync(employee.DepartmentId);
                employeeGetByNameDto = new EmployeeGetByNameDto()
                {
                    Id = employee.Id,
                    DepartmentId = employee.DepartmentId,
                    ProvinceId = employee.ProvinceId,
                    DepartmentName = departmentGetByIdDto.Name,
                    ProvinceName = provinceGetByIdDto.Name,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    Description = employee.Description,
                    Gender = employee.Gender,
                    PhoneNumber = employee.PhoneNumber,
                    PhotoUrl = employee.PhotoUrl,
                    SalaryExpectation = employee.SalaryExpectation,
                    Age = employee.Age,
                    Name = employee.Name,
                };
            }

            return employeeGetByNameDto;
        }

        public async Task UpdateAsync(UpdateEmployee employee)
        {
            await EmployeeRepository.UpdateAsync(new Employee()
            {
                Id = employee.Id,
                Name = employee.Name,
                DepartmentId = employee.DepartmentId,
                ProvinceId = employee.ProvinceId,
                Age = employee.Age,
                Email = employee.Email,
                Description = employee.Description,
                FirstName = employee.FirstName,
                Gender = employee.Gender,
                LastName = employee.LastName,
                PhoneNumber = employee.PhoneNumber,
                PhotoUrl = employee.PhotoUrl,
                SalaryExpectation = employee.SalaryExpectation,
            });
        }

        public async Task DeleteAsync(string name)
        {
            Employee? employee = await EmployeeRepository.GetSingleAsync(employee => employee.Name == name);
            await EmployeeRepository.DeleteAsync(employee);
        }
    }
}
