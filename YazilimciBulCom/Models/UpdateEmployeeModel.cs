using Microsoft.AspNetCore.Mvc.Rendering;
using YazilimciBulCom.Entities.Employees;

namespace YazilimciBulCom.Models
{
    public class UpdateEmployeeModel
    {
        public EmployeeGetByNameDto EmployeeGetByNameDto { get; set; }
        public IQueryable<SelectListItem> Departments { get; set; }
        public IQueryable<SelectListItem> Provinces { get; set; }
    }
}
