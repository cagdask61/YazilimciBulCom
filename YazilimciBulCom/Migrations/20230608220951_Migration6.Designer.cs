﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YazilimciBulCom.Contexts;

#nullable disable

namespace YazilimciBulCom.Migrations
{
    [DbContext(typeof(CommonDbContext))]
    [Migration("20230608220951_Migration6")]
    partial class Migration6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YazilimciBulCom.Entities.Departments.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Front-End Developer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Back-End Developer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Full-Stack Developer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mobile Developer"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Database Developer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Game Developer"
                        });
                });

            modelBuilder.Entity("YazilimciBulCom.Entities.Employees.Employee", b =>
                {
                    b.Property<int>("Id")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("Age")
                        .HasMaxLength(100)
                        .HasColumnType("smallint")
                        .HasColumnName("Age");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("DepartmentId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit")
                        .HasColumnName("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("LastName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhotoUrl");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int")
                        .HasColumnName("ProvinceId");

                    b.Property<int>("SalaryExpectation")
                        .HasColumnType("int")
                        .HasColumnName("SalaryExpectation");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("YazilimciBulCom.Entities.Provinces.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<int>("Number")
                        .IsUnicode(true)
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.HasKey("Id");

                    b.ToTable("Province", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adana",
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adıyaman",
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Afyonkarahisar",
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ağrı",
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Amasya",
                            Number = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ankara",
                            Number = 6
                        },
                        new
                        {
                            Id = 7,
                            Name = "Antalya",
                            Number = 7
                        },
                        new
                        {
                            Id = 8,
                            Name = "Artvin",
                            Number = 8
                        },
                        new
                        {
                            Id = 9,
                            Name = "Aydın",
                            Number = 9
                        },
                        new
                        {
                            Id = 10,
                            Name = "Balıkesir",
                            Number = 10
                        },
                        new
                        {
                            Id = 11,
                            Name = "Bilecik",
                            Number = 11
                        },
                        new
                        {
                            Id = 12,
                            Name = "Bingöl",
                            Number = 12
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bitlis",
                            Number = 13
                        },
                        new
                        {
                            Id = 14,
                            Name = "Bolu",
                            Number = 14
                        },
                        new
                        {
                            Id = 15,
                            Name = "Burdur",
                            Number = 15
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bursa",
                            Number = 16
                        },
                        new
                        {
                            Id = 17,
                            Name = "Çanakkale",
                            Number = 17
                        },
                        new
                        {
                            Id = 18,
                            Name = "Çankırı",
                            Number = 18
                        },
                        new
                        {
                            Id = 19,
                            Name = "Çorum",
                            Number = 19
                        },
                        new
                        {
                            Id = 20,
                            Name = "Denizli",
                            Number = 20
                        },
                        new
                        {
                            Id = 21,
                            Name = "Diyarbakır",
                            Number = 21
                        },
                        new
                        {
                            Id = 22,
                            Name = "Edirne",
                            Number = 22
                        },
                        new
                        {
                            Id = 23,
                            Name = "Elazığ",
                            Number = 23
                        },
                        new
                        {
                            Id = 24,
                            Name = "Erzincan",
                            Number = 24
                        },
                        new
                        {
                            Id = 25,
                            Name = "Erzurum",
                            Number = 25
                        },
                        new
                        {
                            Id = 26,
                            Name = "Eskişehir",
                            Number = 26
                        },
                        new
                        {
                            Id = 27,
                            Name = "Gaziantep",
                            Number = 27
                        },
                        new
                        {
                            Id = 28,
                            Name = "Giresun",
                            Number = 28
                        },
                        new
                        {
                            Id = 29,
                            Name = "Gümüşhane",
                            Number = 29
                        },
                        new
                        {
                            Id = 30,
                            Name = "Hakkari",
                            Number = 30
                        },
                        new
                        {
                            Id = 31,
                            Name = "Hatay",
                            Number = 31
                        },
                        new
                        {
                            Id = 32,
                            Name = "Isparta",
                            Number = 32
                        },
                        new
                        {
                            Id = 33,
                            Name = "Mersin",
                            Number = 33
                        },
                        new
                        {
                            Id = 34,
                            Name = "İstanbul",
                            Number = 34
                        },
                        new
                        {
                            Id = 35,
                            Name = "İzmir",
                            Number = 35
                        },
                        new
                        {
                            Id = 36,
                            Name = "Kars",
                            Number = 36
                        },
                        new
                        {
                            Id = 37,
                            Name = "Kastamonu",
                            Number = 37
                        },
                        new
                        {
                            Id = 38,
                            Name = "Kayseri",
                            Number = 38
                        },
                        new
                        {
                            Id = 39,
                            Name = "Kırklareli",
                            Number = 39
                        },
                        new
                        {
                            Id = 40,
                            Name = "Kırşehir",
                            Number = 40
                        },
                        new
                        {
                            Id = 41,
                            Name = "Kocaeli",
                            Number = 41
                        },
                        new
                        {
                            Id = 42,
                            Name = "Konya",
                            Number = 42
                        },
                        new
                        {
                            Id = 43,
                            Name = "Kütahya",
                            Number = 43
                        },
                        new
                        {
                            Id = 44,
                            Name = "Malatya",
                            Number = 44
                        },
                        new
                        {
                            Id = 45,
                            Name = "Manisa",
                            Number = 45
                        },
                        new
                        {
                            Id = 46,
                            Name = "Kahramanmaraş",
                            Number = 46
                        },
                        new
                        {
                            Id = 47,
                            Name = "Mardin",
                            Number = 47
                        },
                        new
                        {
                            Id = 48,
                            Name = "Muğla",
                            Number = 48
                        },
                        new
                        {
                            Id = 49,
                            Name = "Muş",
                            Number = 49
                        },
                        new
                        {
                            Id = 50,
                            Name = "Nevşehir",
                            Number = 50
                        },
                        new
                        {
                            Id = 51,
                            Name = "Niğde",
                            Number = 51
                        },
                        new
                        {
                            Id = 52,
                            Name = "Ordu",
                            Number = 52
                        },
                        new
                        {
                            Id = 53,
                            Name = "Rize",
                            Number = 53
                        },
                        new
                        {
                            Id = 54,
                            Name = "Sakarya",
                            Number = 54
                        },
                        new
                        {
                            Id = 55,
                            Name = "Samsun",
                            Number = 55
                        },
                        new
                        {
                            Id = 56,
                            Name = "Siirt",
                            Number = 56
                        },
                        new
                        {
                            Id = 57,
                            Name = "Sinop",
                            Number = 57
                        },
                        new
                        {
                            Id = 58,
                            Name = "Sivas",
                            Number = 58
                        },
                        new
                        {
                            Id = 59,
                            Name = "Tekirdağ",
                            Number = 59
                        },
                        new
                        {
                            Id = 60,
                            Name = "Tokat",
                            Number = 60
                        },
                        new
                        {
                            Id = 61,
                            Name = "Trabzon",
                            Number = 61
                        },
                        new
                        {
                            Id = 62,
                            Name = "Tunceli",
                            Number = 62
                        },
                        new
                        {
                            Id = 63,
                            Name = "Şanlıurfa",
                            Number = 63
                        },
                        new
                        {
                            Id = 64,
                            Name = "Uşak",
                            Number = 64
                        },
                        new
                        {
                            Id = 65,
                            Name = "Van",
                            Number = 65
                        },
                        new
                        {
                            Id = 66,
                            Name = "Yozgat",
                            Number = 66
                        },
                        new
                        {
                            Id = 67,
                            Name = "Zonguldak",
                            Number = 67
                        },
                        new
                        {
                            Id = 68,
                            Name = "Aksaray",
                            Number = 68
                        },
                        new
                        {
                            Id = 69,
                            Name = "Bayburt",
                            Number = 69
                        },
                        new
                        {
                            Id = 70,
                            Name = "Karaman",
                            Number = 70
                        },
                        new
                        {
                            Id = 71,
                            Name = "Kırıkkale",
                            Number = 71
                        },
                        new
                        {
                            Id = 72,
                            Name = "Batman",
                            Number = 72
                        },
                        new
                        {
                            Id = 73,
                            Name = "Şırnak",
                            Number = 73
                        },
                        new
                        {
                            Id = 74,
                            Name = "Bartın",
                            Number = 74
                        },
                        new
                        {
                            Id = 75,
                            Name = "Ardahan",
                            Number = 75
                        },
                        new
                        {
                            Id = 76,
                            Name = "Iğdır",
                            Number = 76
                        },
                        new
                        {
                            Id = 77,
                            Name = "Yalova",
                            Number = 77
                        },
                        new
                        {
                            Id = 78,
                            Name = "Karabük",
                            Number = 78
                        },
                        new
                        {
                            Id = 79,
                            Name = "Kilis",
                            Number = 79
                        },
                        new
                        {
                            Id = 80,
                            Name = "Osmaniye",
                            Number = 80
                        },
                        new
                        {
                            Id = 81,
                            Name = "Düzce",
                            Number = 81
                        });
                });

            modelBuilder.Entity("YazilimciBulCom.Entities.Employees.Employee", b =>
                {
                    b.HasOne("YazilimciBulCom.Entities.Departments.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YazilimciBulCom.Entities.Provinces.Province", "Province")
                        .WithMany("Employees")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("YazilimciBulCom.Entities.Departments.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("YazilimciBulCom.Entities.Provinces.Province", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}