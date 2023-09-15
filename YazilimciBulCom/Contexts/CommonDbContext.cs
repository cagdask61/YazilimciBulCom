using Microsoft.EntityFrameworkCore;
using YazilimciBulCom.Entities.Departments;
using YazilimciBulCom.Entities.Employees;
using YazilimciBulCom.Entities.Provinces;

namespace YazilimciBulCom.Contexts
{
    public class CommonDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Province> Provinces { get; set; }

        public CommonDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(build =>
            {
                build.ToTable("Departments");
                build.Property(department => department.Id).HasColumnName("Id");
                build.Property(department => department.Name).HasColumnName("Name").HasMaxLength(70);
                build.HasMany(department => department.Employees);

            });

            modelBuilder.Entity<Employee>(build =>
            {
                build.ToTable("Employees");
                build.Property(employee => employee.Id).HasColumnName("Id");
                build.Property(employee => employee.DepartmentId).HasColumnName("DepartmentId");
                build.Property(employee => employee.ProvinceId).HasColumnName("ProvinceId");
                build.Property(employee => employee.FirstName).HasColumnName("FirstName").HasMaxLength(50);
                build.Property(employee => employee.LastName).HasColumnName("LastName").HasMaxLength(60);
                build.Property(employee => employee.Description).HasColumnName("Description");
                build.Property(employee => employee.Email).HasColumnName("Email").HasMaxLength(70);
                build.Property(employee => employee.Gender).HasColumnName("Gender");
                build.Property(employee => employee.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(11);
                build.Property(employee => employee.PhotoUrl).HasColumnName("PhotoUrl");
                build.Property(employee => employee.SalaryExpectation).HasColumnName("SalaryExpectation");
                build.Property(employee => employee.Age).HasColumnName("Age").HasMaxLength(100);
                build.Property(employee => employee.Name).HasColumnName("Name");
                build.HasOne(employee => employee.Department);
                build.HasOne(employee => employee.Province);

            });

            modelBuilder.Entity<Province>(build =>
            {
                build.ToTable("Province");
                build.Property(province => province.Id).HasColumnName("Id");
                build.Property(province => province.Number).HasColumnName("Number").IsUnicode(true);
                build.Property(province => province.Name).HasColumnName("Name").HasMaxLength(100);
                build.HasMany(province => province.Employees);
            });


            List<Department> departments = new()
            {
                new(){Id=1, Name = "Front-End Developer"},
                new(){Id=2, Name = "Back-End Developer"},
                new(){Id=3, Name = "Full-Stack Developer"},
                new(){Id=4, Name = "Mobile Developer"},
                new(){Id=5, Name = "Database Developer"},
                new(){Id=6, Name = "Game Developer"},
            };
            modelBuilder.Entity<Department>().HasData(departments);

            List<Province> provinces = new()
            {
                new() {Id=1,Number=1,Name="Adana"},
                    new() {Id=2,Number=2,Name="Adıyaman"},
                    new() {Id=3,Number=3,Name="Afyonkarahisar"},
                    new() {Id=4,Number=4,Name="Ağrı"},
                    new() {Id=5,Number=5,Name="Amasya"},
                    new() {Id=6,Number=6,Name="Ankara"},
                    new() {Id=7,Number=7,Name="Antalya"},
                    new() {Id=8,Number=8,Name="Artvin"},
                    new() {Id=9,Number=9,Name="Aydın"},
                    new() {Id=10,Number=10,Name="Balıkesir"},
                    new() {Id=11,Number=11,Name="Bilecik"},
                    new() {Id=12,Number=12,Name="Bingöl"},
                    new() {Id=13,Number=13,Name="Bitlis"},
                    new() {Id=14,Number=14,Name="Bolu"},
                    new() {Id=15,Number=15,Name="Burdur"},
                    new() {Id=16,Number=16,Name="Bursa"},
                    new() {Id=17,Number=17,Name="Çanakkale"},
                    new() {Id=18,Number=18,Name="Çankırı"},
                    new() {Id=19,Number=19,Name="Çorum"},
                    new() {Id=20,Number=20,Name="Denizli"},
                    new() {Id=21,Number=21,Name="Diyarbakır"},
                    new() {Id=22,Number=22,Name="Edirne"},
                    new() {Id=23,Number=23,Name="Elazığ"},
                    new() {Id=24,Number=24,Name="Erzincan"},
                    new() {Id=25,Number=25,Name="Erzurum"},
                    new() {Id=26,Number=26,Name="Eskişehir"},
                    new() {Id=27,Number=27,Name="Gaziantep"},
                    new() {Id=28,Number=28,Name="Giresun"},
                    new() {Id=29,Number=29,Name="Gümüşhane"},
                    new() {Id=30,Number=30,Name="Hakkari"},
                    new() {Id=31,Number=31,Name="Hatay"},
                    new() {Id=32,Number=32,Name="Isparta"},
                    new() {Id=33,Number=33,Name="Mersin"},
                    new() {Id=34,Number=34,Name="İstanbul"},
                    new() {Id=35,Number=35,Name="İzmir"},
                    new() {Id=36,Number=36,Name="Kars"},
                    new() {Id=37,Number=37,Name="Kastamonu"},
                    new() {Id=38,Number=38,Name="Kayseri"},
                    new() {Id=39,Number=39,Name="Kırklareli"},
                    new() {Id=40,Number=40,Name="Kırşehir"},
                    new() {Id=41,Number=41,Name="Kocaeli"},
                    new() {Id=42,Number=42,Name="Konya"},
                    new() {Id=43,Number=43,Name="Kütahya"},
                    new() {Id=44,Number=44,Name="Malatya"},
                    new() {Id=45,Number=45,Name="Manisa"},
                    new() {Id=46,Number=46,Name="Kahramanmaraş"},
                    new() {Id=47,Number=47,Name="Mardin"},
                    new() {Id=48,Number=48,Name="Muğla"},
                    new() {Id=49,Number=49,Name="Muş"},
                    new() {Id=50,Number=50,Name="Nevşehir"},
                    new() {Id=51,Number=51,Name="Niğde"},
                    new() {Id=52,Number=52,Name="Ordu"},
                    new() {Id=53,Number=53,Name="Rize"},
                    new() {Id=54,Number=54,Name="Sakarya"},
                    new() {Id=55,Number=55,Name="Samsun"},
                    new() {Id=56,Number=56,Name="Siirt"},
                    new() {Id=57,Number=57,Name="Sinop"},
                    new() {Id=58,Number=58,Name="Sivas"},
                    new() {Id=59,Number=59,Name="Tekirdağ"},
                    new() {Id=60,Number=60,Name="Tokat"},
                    new() {Id=61,Number=61,Name="Trabzon"},
                    new() {Id=62,Number=62,Name="Tunceli"},
                    new() {Id=63,Number=63,Name="Şanlıurfa"},
                    new() {Id=64,Number=64,Name="Uşak"},
                    new() {Id=65,Number=65,Name="Van"},
                    new() {Id=66,Number=66,Name="Yozgat"},
                    new() {Id=67,Number=67,Name="Zonguldak"},
                    new() {Id=68,Number=68,Name="Aksaray"},
                    new() {Id=69,Number=69,Name="Bayburt"},
                    new() {Id=70,Number=70,Name="Karaman"},
                    new() {Id=71,Number=71,Name="Kırıkkale"},
                    new() {Id=72,Number=72,Name="Batman"},
                    new() {Id=73,Number=73,Name="Şırnak"},
                    new() {Id=74,Number=74,Name="Bartın"},
                    new() {Id=75,Number=75,Name="Ardahan"},
                    new() {Id=76,Number=76,Name="Iğdır"},
                    new() {Id=77,Number=77,Name="Yalova"},
                    new() {Id=78,Number=78,Name="Karabük"},
                    new() {Id=79,Number=79,Name="Kilis"},
                    new() {Id=80,Number=80,Name="Osmaniye"},
                    new() {Id=81,Number=81,Name="Düzce"}
            };
            modelBuilder.Entity<Province>().HasData(provinces);
        }
    }
}