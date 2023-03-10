// <auto-generated />
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
    [Migration("20230119203811_AddDeletedTriggerToEmployeeAttendanceTable")]
    partial class AddDeletedTriggerToEmployeeAttendanceTable
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
