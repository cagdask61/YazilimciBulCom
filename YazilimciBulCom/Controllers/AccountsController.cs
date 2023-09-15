using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using YazilimciBulCom.Entities.Employees;
using YazilimciBulCom.Models;
using YazilimciBulCom.Services.Abstract;

namespace YazilimciBulCom.Controllers
{
    public class AccountsController : Controller
    {
        private IEmployeeService EmployeeService { get; set; }
        public AccountsController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Profile));
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            string? _picture = User.Claims.FirstOrDefault(claim => claim.Type == "picture")?.Value;
            string? _nickname = User.Claims.FirstOrDefault(claim => claim.Type == "nickname")?.Value;
            string? _firstName = User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.GivenName)?.Value;
            string? _lastName = User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Surname)?.Value;
            string? _email = User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)?.Value;

            foreach (var item in User.Claims)
            {
                Console.WriteLine($"type = {item.Type} || value = {item.Value}");
            }

            EmployeeGetByNameDto? employee = await EmployeeService.GetByNameAsync(_nickname);

            return View(new ProfileModel()
            {
                Name = User.Identity.Name,
                Picture = _picture,
                NickName = _nickname,
                FirstName = _firstName,
                LastName = _lastName,
                Email = _email,
                EmployeeGetByNameDto = employee
            });
        }


        [Authorize]
        public async Task Logout()
        {
            var authenticationProperties = new LogoutAuthenticationPropertiesBuilder().WithRedirectUri(Url.Action("Index", "Employees")).Build();
            await HttpContext.SignOutAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

       
    }
}
