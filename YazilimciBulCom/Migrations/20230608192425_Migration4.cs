using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YazilimciBulCom.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<short>(
                name: "Age",
                table: "Employees",
                type: "smallint",
                maxLength: 100,
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Description", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoUrl", "ProvinceId", "SalaryExpectation" },
                values: new object[,]
                {
                    { 1, 2, "SelamunAleyküm, Ben Çağdaş Türkiye'nin Antalya ilinde yaşayan yazılım geliştiricisiyim. Yazılım hayatıma 2020 yılında başladım ve bu zamana kadar yazılım geliştirmeye devam ettirmekteyim. Keçiborlu Meslek Yüksekokulu Bilgisayar Programcılğı öğrencisiyim.", "kocamancagdas59@gmail.com", "Çağdaş", false, "Kocaman", "05366807040", "https://lh3.googleusercontent.com/a/AGNmyxaKqlT-A2Qco2M-6RUPfJedYPTMCkaTst2OPRdUhA=s288", 7, 10000 },
                    { 2, 2, "SelamunAleyküm, Ben Çağdaş Türkiye'nin Antalya ilinde yaşayan yazılım geliştiricisiyim. Yazılım hayatıma 2020 yılında başladım ve bu zamana kadar yazılım geliştirmeye devam ettirmekteyim. Keçiborlu Meslek Yüksekokulu Bilgisayar Programcılğı öğrencisiyim.", "kocamancagdas59@gmail.com", "Çağdaş", false, "Kocaman", "05366807040", "https://lh3.googleusercontent.com/a/AGNmyxaKqlT-A2Qco2M-6RUPfJedYPTMCkaTst2OPRdUhA=s288", 7, 10000 }
                });
        }
    }
}
