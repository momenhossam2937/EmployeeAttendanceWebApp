using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAttendanceWebApp.Persistence.Migrations
{
    public partial class AddInsertedTriggerToEmployeeAttendanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TRIGGER dbo.trgEmployeeAttendanceInsert
       ON dbo.EmployeeAttendances
AFTER INSERT
AS
BEGIN
       SET NOCOUNT ON;
	   DECLARE @Id INT
       DECLARE @OldCount INT
       DECLARE @NewCount INT
       select @OldCount= count(*) from dbo.EmployeeAttendances
	   select @NewCount= count(*) from dbo.EmployeeAttendanceDateTime
       SELECT @Id = INSERTED.Id       
	     FROM dbo.EmployeeAttendances INSERTED

	   if(@OldCount != @NewCount+1)
	   begin
	   
       INSERT INTO dbo.EmployeeAttendanceDateTime
         SELECT Id,EVETLGUID,SRVDT ,dateadd(S, DEVDT, '1970-01-01') ,DEVUID,EMPID FROM dbo.EmployeeAttendances 
	   end
      if(@OldCount = @NewCount+1)
	   begin
	        INSERT INTO dbo.EmployeeAttendanceDateTime
         SELECT top(1) Id,EVETLGUID,SRVDT ,dateadd(S, DEVDT, '1970-01-01') ,DEVUID,EMPID FROM dbo.EmployeeAttendances  order by Id desc
	   end
 
  
END");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP TRIGGER dbo.trgEmployeeAttendanceInsert");
        }
    }
}
