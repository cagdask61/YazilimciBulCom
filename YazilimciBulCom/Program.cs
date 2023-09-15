using Auth0.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using YazilimciBulCom.Contexts;
using YazilimciBulCom.Extensions;
using YazilimciBulCom.Repositories.Abstract;
using YazilimciBulCom.Repositories.Concrete;
using YazilimciBulCom.Services.Abstract;
using YazilimciBulCom.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
});
//builder.Services.ConfigureSiteNoneCookies();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CommonDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQL")));

builder.Services.AddScoped<IEmployeeService, EmployeeManager>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddScoped<IDepartmentService, DepartmentManager>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

builder.Services.AddScoped<IProvinceService, ProvinceManager>();
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
