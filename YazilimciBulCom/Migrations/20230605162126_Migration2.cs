using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YazilimciBulCom.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Front-End Developer" },
                    { 2, "Back-End Developer" },
                    { 3, "Full-Stack Developer" },
                    { 4, "Mobile Developer" },
                    { 5, "Database Developer" },
                    { 6, "Game Developer" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Description", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoUrl", "SalaryExpectation" },
                values: new object[,]
                {
                    { 1, 2, "SelamunAleyküm, Ben Çağdaş Türkiye'nin Antalya ilinde yaşayan yazılım geliştiricisiyim. Yazılım hayatıma 2020 yılında başladım ve bu zamana kadar yazılım geliştirmeye devam ettirmekteyim. Keçiborlu Meslek Yüksekokulu Bilgisayar Programcılğı öğrencisiyim.", "kocamancagdas59@gmail.com", "Çağdaş", false, "Kocaman", "05366807040", "", 10000 },
                    { 2, 2, "SelamunAleyküm, Ben Çağdaş Türkiye'nin Antalya ilinde yaşayan yazılım geliştiricisiyim. Yazılım hayatıma 2020 yılında başladım ve bu zamana kadar yazılım geliştirmeye devam ettirmekteyim. Keçiborlu Meslek Yüksekokulu Bilgisayar Programcılğı öğrencisiyim.", "kocamancagdas59@gmail.com", "Çağdaş", false, "Kocaman", "05366807040", "", 10000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
