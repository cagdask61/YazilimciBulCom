﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YazilimciBulCom.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PhotoUrl", "ProvinceId" },
                values: new object[] { "https://lh3.googleusercontent.com/a/AGNmyxaKqlT-A2Qco2M-6RUPfJedYPTMCkaTst2OPRdUhA=s288", 7 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PhotoUrl", "ProvinceId" },
                values: new object[] { "https://lh3.googleusercontent.com/a/AGNmyxaKqlT-A2Qco2M-6RUPfJedYPTMCkaTst2OPRdUhA=s288", 7 });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { 1, "Adana", 1 },
                    { 2, "Adıyaman", 2 },
                    { 3, "Afyonkarahisar", 3 },
                    { 4, "Ağrı", 4 },
                    { 5, "Amasya", 5 },
                    { 6, "Ankara", 6 },
                    { 7, "Antalya", 7 },
                    { 8, "Artvin", 8 },
                    { 9, "Aydın", 9 },
                    { 10, "Balıkesir", 10 },
                    { 11, "Bilecik", 11 },
                    { 12, "Bingöl", 12 },
                    { 13, "Bitlis", 13 },
                    { 14, "Bolu", 14 },
                    { 15, "Burdur", 15 },
                    { 16, "Bursa", 16 },
                    { 17, "Çanakkale", 17 },
                    { 18, "Çankırı", 18 },
                    { 19, "Çorum", 19 },
                    { 20, "Denizli", 20 },
                    { 21, "Diyarbakır", 21 },
                    { 22, "Edirne", 22 },
                    { 23, "Elazığ", 23 },
                    { 24, "Erzincan", 24 },
                    { 25, "Erzurum", 25 },
                    { 26, "Eskişehir", 26 },
                    { 27, "Gaziantep", 27 },
                    { 28, "Giresun", 28 },
                    { 29, "Gümüşhane", 29 },
                    { 30, "Hakkari", 30 },
                    { 31, "Hatay", 31 },
                    { 32, "Isparta", 32 },
                    { 33, "Mersin", 33 },
                    { 34, "İstanbul", 34 },
                    { 35, "İzmir", 35 },
                    { 36, "Kars", 36 },
                    { 37, "Kastamonu", 37 },
                    { 38, "Kayseri", 38 },
                    { 39, "Kırklareli", 39 },
                    { 40, "Kırşehir", 40 },
                    { 41, "Kocaeli", 41 },
                    { 42, "Konya", 42 },
                    { 43, "Kütahya", 43 },
                    { 44, "Malatya", 44 },
                    { 45, "Manisa", 45 },
                    { 46, "Kahramanmaraş", 46 },
                    { 47, "Mardin", 47 },
                    { 48, "Muğla", 48 },
                    { 49, "Muş", 49 },
                    { 50, "Nevşehir", 50 },
                    { 51, "Niğde", 51 },
                    { 52, "Ordu", 52 },
                    { 53, "Rize", 53 },
                    { 54, "Sakarya", 54 },
                    { 55, "Samsun", 55 },
                    { 56, "Siirt", 56 },
                    { 57, "Sinop", 57 },
                    { 58, "Sivas", 58 },
                    { 59, "Tekirdağ", 59 },
                    { 60, "Tokat", 60 },
                    { 61, "Trabzon", 61 },
                    { 62, "Tunceli", 62 },
                    { 63, "Şanlıurfa", 63 },
                    { 64, "Uşak", 64 },
                    { 65, "Van", 65 },
                    { 66, "Yozgat", 66 },
                    { 67, "Zonguldak", 67 },
                    { 68, "Aksaray", 68 },
                    { 69, "Bayburt", 69 },
                    { 70, "Karaman", 70 },
                    { 71, "Kırıkkale", 71 },
                    { 72, "Batman", 72 },
                    { 73, "Şırnak", 73 },
                    { 74, "Bartın", 74 },
                    { 75, "Ardahan", 75 },
                    { 76, "Iğdır", 76 },
                    { 77, "Yalova", 77 },
                    { 78, "Karabük", 78 },
                    { 79, "Kilis", 79 },
                    { 80, "Osmaniye", 80 },
                    { 81, "Düzce", 81 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProvinceId",
                table: "Employees",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Province_ProvinceId",
                table: "Employees",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Province_ProvinceId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProvinceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "");
        }
    }
}
