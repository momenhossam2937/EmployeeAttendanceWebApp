using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAttendanceWebApp.Persistence.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeAttendanceDateTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true),
                    EVETLGUID = table.Column<long>(type: "bigint", nullable: false),
                    SRVDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEVDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEVUID = table.Column<long>(type: "bigint", nullable: false),
                    EMPID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EMPID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EMPID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EVETLGUID = table.Column<long>(type: "bigint", maxLength: 255, nullable: false),
                    SRVDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEVDT = table.Column<long>(type: "bigint", nullable: false),
                    DEVUID = table.Column<long>(type: "bigint", nullable: false),
                    EMPID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAttendances_Employees_EMPID",
                        column: x => x.EMPID,
                        principalTable: "Employees",
                        principalColumn: "EMPID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendances_EMPID",
                table: "EmployeeAttendances",
                column: "EMPID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAttendanceDateTime");

            migrationBuilder.DropTable(
                name: "EmployeeAttendances");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
