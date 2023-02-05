using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAttendanceWebApp.Persistence.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EMPID", "Email", "IsActive", "Name", "PhoneNo" },
                values: new object[] { 1234L, "test@test.com", true, "user", "123456" });

            migrationBuilder.InsertData(
                table: "EmployeeAttendances",
                columns: new[] { "Id", "DEVDT", "DEVUID", "EMPID", "EVETLGUID", "SRVDT" },
                values: new object[,]
                {
                    { 1, 1672633967L, 939265762L, 1234L, 846L, new DateTime(2023, 1, 2, 8, 32, 52, 0, DateTimeKind.Unspecified) },
                    { 2, 1672662587L, 939265762L, 1234L, 1518L, new DateTime(2023, 1, 2, 16, 29, 51, 0, DateTimeKind.Unspecified) },
                    { 3, 1672716474L, 939265762L, 1234L, 1971L, new DateTime(2023, 1, 3, 7, 27, 59, 0, DateTimeKind.Unspecified) },
                    { 4, 1672745281L, 939265762L, 1234L, 2676L, new DateTime(2023, 1, 3, 15, 28, 1, 0, DateTimeKind.Unspecified) },
                    { 5, 1672805230L, 939265762L, 1234L, 4369L, new DateTime(2023, 1, 4, 10, 14, 40, 0, DateTimeKind.Unspecified) },
                    { 6, 1672836346L, 939265762L, 1234L, 5026L, new DateTime(2023, 1, 4, 16, 45, 48, 0, DateTimeKind.Unspecified) },
                    { 7, 1672892904L, 939265762L, 1234L, 5488L, new DateTime(2023, 1, 5, 8, 28, 25, 0, DateTimeKind.Unspecified) },
                    { 8, 1672921687L, 939265762L, 1234L, 5968L, new DateTime(2023, 1, 5, 16, 28, 9, 0, DateTimeKind.Unspecified) },
                    { 9, 1673238788L, 939265762L, 1234L, 7326L, new DateTime(2023, 1, 9, 8, 33, 13, 0, DateTimeKind.Unspecified) },
                    { 10, 1673267481L, 939265762L, 1234L, 7830L, new DateTime(2023, 1, 9, 16, 31, 26, 0, DateTimeKind.Unspecified) },
                    { 11, 1673325481L, 939265762L, 1234L, 8309L, new DateTime(2023, 1, 10, 8, 38, 6, 0, DateTimeKind.Unspecified) },
                    { 12, 1673331966L, 939265762L, 1234L, 8310L, new DateTime(2023, 1, 10, 10, 21, 6, 0, DateTimeKind.Unspecified) },
                    { 13, 1673334916L, 939265762L, 1234L, 8311L, new DateTime(2023, 1, 10, 11, 15, 16, 0, DateTimeKind.Unspecified) },
                    { 14, 1673343946L, 939265762L, 1234L, 8312L, new DateTime(2023, 1, 10, 13, 45, 46, 0, DateTimeKind.Unspecified) },
                    { 15, 1673527118L, 939265762L, 1234L, 8313L, new DateTime(2023, 1, 10, 16, 38, 38, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EmployeeAttendances",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EMPID",
                keyValue: 1234L);
        }
    }
}
