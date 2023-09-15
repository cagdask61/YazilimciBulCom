using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using YazilimciBulCom.Entities.Departments;
using YazilimciBulCom.Entities.Employees;
using YazilimciBulCom.Entities.Provinces;
using YazilimciBulCom.Models;
using YazilimciBulCom.Services.Abstract;

namespace YazilimciBulCom.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeService EmployeeService { get; set; }
        private IDepartmentService DepartmentService { get; set; }
        private IProvinceService ProvinceService { get; set; }

        public EmployeesController(IEmployeeService employeeService, IProvinceService provinceService, IDepartmentService departmentService)
        {
            EmployeeService = employeeService;
            ProvinceService = provinceService;
            DepartmentService = departmentService;
        }

        public IActionResult Index()
        {
            return View(new EmployeeModel()
            {
                Employees = EmployeeService.GetAll(),
                Departments = DepartmentService.GetAll().Select(department => new SelectListItem(department.Name, department.Id.ToString())),
                Provinces = ProvinceService.GetAll().Select(province => new SelectListItem(province.Name, province.Id.ToString()))
            });
        }

        public IActionResult Filter([FromQuery] EmployeeFilterModel filterModel)
        {
            int provinceId = Convert.ToInt32(filterModel.Province);
            int departmentId = Convert.ToInt32(filterModel.Department);

            return View(nameof(Index), new EmployeeModel()
            {
                Employees = EmployeeService.GetAllByFilter(provinceId, departmentId),
                Departments = DepartmentService.GetAll().Select(department => new SelectListItem(department.Name, department.Id.ToString())),
                Provinces = ProvinceService.GetAll().Select(province => new SelectListItem(province.Name, province.Id.ToString()))
            });
        }

        public async Task<IActionResult> Detail(int employeeId)
        {
            EmployeeGetByIdDto employeeGetByIdDto = await EmployeeService.GetByIdAsync(employeeId);

            return View(employeeGetByIdDto);
        }


        [Authorize]
        public IActionResult Join()
        {
            return View(new EmployeeModel()
            {
                Employees = null,
                Departments = DepartmentService.GetAll().Select(department => new SelectListItem(department.Name, department.Id.ToString())),
                Provinces = ProvinceService.GetAll().Select(province => new SelectListItem(province.Name, province.Id.ToString()))
            });
        }

        [Authorize, HttpPost]
        public async Task<IActionResult> CreateProfile(CreateEmployeeModel model)
        {
            string? _nickname = User.Claims.FirstOrDefault(claim => claim.Type == "nickname")?.Value;

            await EmployeeService.AddAsync(new CreateEmployee()
            {
                Name = _nickname,
                Description = model.Description,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                SalaryExpectation = model.SalaryExpectation,
                Age = model.Age,
                PhotoUrl = model.PhotoUrl,
                Gender = Convert.ToBoolean(model.Gender),
                DepartmentId = Convert.ToInt32(model.Department),
                ProvinceId = Convert.ToInt32(model.Province)
            });

            return RedirectToAction("Profile", "Accounts");
        }

        [Authorize]
        public async Task<IActionResult> DeleteProfile()
        {
            string? _nickname = User.Claims.FirstOrDefault(claim => claim.Type == "nickname")?.Value;
            await EmployeeService.DeleteAsync(_nickname);
            return RedirectToAction("Profile", "Accounts");
        }

        [Authorize, HttpGet]
        public async Task<IActionResult> Update()
        {
            string? _nickname = User.Claims.FirstOrDefault(claim => claim.Type == "nickname")?.Value;
            EmployeeGetByNameDto employeeGetByNameDto = await EmployeeService.GetByNameAsync(_nickname);
            return View(new UpdateEmployeeModel()
            {
                EmployeeGetByNameDto = employeeGetByNameDto,
                Departments = DepartmentService.GetAll().Select(department => new SelectListItem(department.Name, department.Id.ToString())),
                Provinces = ProvinceService.GetAll().Select(province => new SelectListItem(province.Name, province.Id.ToString()))
            });
        }

        [Authorize, HttpPost]
        public async Task<IActionResult> UpdateProfile(UpdateProfileModel model)
        {
            string? _nickname = User.Claims.FirstOrDefault(claim => claim.Type == "nickname")?.Value;
            await EmployeeService.UpdateAsync(new UpdateEmployee()
            {
                Id = model.Id,
                Name = _nickname,
                DepartmentId = Convert.ToInt32(model.Department),
                ProvinceId = Convert.ToInt32(model.Province),
                Age = model.Age,
                Email = model.Email,
                Description = model.Description,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = Convert.ToBoolean(model.Gender),
                PhoneNumber = model.PhoneNumber,
                PhotoUrl = model.PhotoUrl,
                SalaryExpectation = model.SalaryExpectation,
            });

            return RedirectToAction("Profile", "Accounts");
        }
    }
}
