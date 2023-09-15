using Microsoft.AspNetCore.Mvc.Rendering;
using YazilimciBulCom.Entities.Employees;

namespace YazilimciBulCom.Models
{
    public class EmployeeModel
    {
        public IQueryable<EmployeeListDto>? Employees { get; set; }
        public IQueryable<SelectListItem> Departments { get; set; }
        public IQueryable<SelectListItem> Provinces { get; set; }
    }
}
