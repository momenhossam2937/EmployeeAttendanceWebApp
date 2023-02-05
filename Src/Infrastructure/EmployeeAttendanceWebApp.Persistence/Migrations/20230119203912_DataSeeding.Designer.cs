﻿// <auto-generated />
using System;
using EmployeeAttendanceWebApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeAttendanceWebApp.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230119203912_DataSeeding")]
    partial class DataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeAttendanceWebApp.Domain.Entities.Employee", b =>
                {
                    b.Property<long>("EMPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EMPID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EMPID = 1234L,
                            Email = "test@test.com",
                            IsActive = true,
                            Name = "user",
                            PhoneNo = "123456"
                        });
                });

            modelBuilder.Entity("EmployeeAttendanceWebApp.Domain.Entities.EmployeeAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DEVDT")
                        .HasColumnType("bigint");

                    b.Property<long>("DEVUID")
                        .HasColumnType("bigint");

                    b.Property<long>("EMPID")
                        .HasColumnType("bigint");

                    b.Property<long>("EVETLGUID")
                        .HasMaxLength(255)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SRVDT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EMPID");

                    b.ToTable("EmployeeAttendances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DEVDT = 1672633967L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 846L,
                            SRVDT = new DateTime(2023, 1, 2, 8, 32, 52, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DEVDT = 1672662587L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 1518L,
                            SRVDT = new DateTime(2023, 1, 2, 16, 29, 51, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DEVDT = 1672716474L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 1971L,
                            SRVDT = new DateTime(2023, 1, 3, 7, 27, 59, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            DEVDT = 1672745281L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 2676L,
                            SRVDT = new DateTime(2023, 1, 3, 15, 28, 1, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            DEVDT = 1672805230L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 4369L,
                            SRVDT = new DateTime(2023, 1, 4, 10, 14, 40, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            DEVDT = 1672836346L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 5026L,
                            SRVDT = new DateTime(2023, 1, 4, 16, 45, 48, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            DEVDT = 1672892904L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 5488L,
                            SRVDT = new DateTime(2023, 1, 5, 8, 28, 25, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            DEVDT = 1672921687L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 5968L,
                            SRVDT = new DateTime(2023, 1, 5, 16, 28, 9, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            DEVDT = 1673238788L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 7326L,
                            SRVDT = new DateTime(2023, 1, 9, 8, 33, 13, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            DEVDT = 1673267481L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 7830L,
                            SRVDT = new DateTime(2023, 1, 9, 16, 31, 26, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            DEVDT = 1673325481L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 8309L,
                            SRVDT = new DateTime(2023, 1, 10, 8, 38, 6, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            DEVDT = 1673331966L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 8310L,
                            SRVDT = new DateTime(2023, 1, 10, 10, 21, 6, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            DEVDT = 1673334916L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 8311L,
                            SRVDT = new DateTime(2023, 1, 10, 11, 15, 16, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            DEVDT = 1673343946L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 8312L,
                            SRVDT = new DateTime(2023, 1, 10, 13, 45, 46, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            DEVDT = 1673527118L,
                            DEVUID = 939265762L,
                            EMPID = 1234L,
                            EVETLGUID = 8313L,
                            SRVDT = new DateTime(2023, 1, 10, 16, 38, 38, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EmployeeAttendanceWebApp.Domain.Entities.EmployeeAttendanceDateTime", b =>
                {
                    b.Property<DateTime>("DEVDT")
                        .HasColumnType("datetime2");

                    b.Property<long>("DEVUID")
                        .HasColumnType("bigint");

                    b.Property<long>("EMPID")
                        .HasColumnType("bigint");

                    b.Property<long>("EVETLGUID")
                        .HasColumnType("bigint");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("SRVDT")
                        .HasColumnType("datetime2");

                    b.ToTable("EmployeeAttendanceDateTime");
                });

            modelBuilder.Entity("EmployeeAttendanceWebApp.Domain.Entities.EmployeeAttendance", b =>
                {
                    b.HasOne("EmployeeAttendanceWebApp.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeAttendances")
                        .HasForeignKey("EMPID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeAttendanceWebApp.Domain.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeAttendances");
                });
#pragma warning restore 612, 618
        }
    }
}
