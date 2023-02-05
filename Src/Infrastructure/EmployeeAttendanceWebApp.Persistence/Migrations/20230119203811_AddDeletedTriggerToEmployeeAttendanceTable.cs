using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAttendanceWebApp.Persistence.Migrations
{
    public partial class AddDeletedTriggerToEmployeeAttendanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TRIGGER dbo.trgEmployeeAttendanceDeleted
ON dbo.EmployeeAttendances
FOR Delete	
AS
   DELETE FROM dbo.EmployeeAttendanceDateTime
    WHERE Id Not IN(SELECT dbo.EmployeeAttendances.Id FROM dbo.EmployeeAttendances)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP TRIGGER dbo.trgEmployeeAttendanceDeleted");
        }
    }
}
