using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_MAnagement_System.Migrations
{
    /// <inheritdoc />
    public partial class AddEID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Leave",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Leave");

            migrationBuilder.AlterColumn<int>(
                name: "LeaveId",
                table: "Leave",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "employeeId",
                table: "Leave",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leave",
                table: "Leave",
                column: "LeaveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Leave",
                table: "Leave");

            migrationBuilder.DropColumn(
                name: "employeeId",
                table: "Leave");

            migrationBuilder.AlterColumn<int>(
                name: "LeaveId",
                table: "Leave",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Leave",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leave",
                table: "Leave",
                column: "Id");
        }
    }
}
