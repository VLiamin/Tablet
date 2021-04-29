using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Assignment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeetingAssignmentModels",
                table: "MeetingAssignmentModels");

            migrationBuilder.RenameTable(
                name: "MeetingAssignmentModels",
                newName: "MeetingAssignmentModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeetingAssignmentModel",
                table: "MeetingAssignmentModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MeetingAssignmentModel",
                table: "MeetingAssignmentModel");

            migrationBuilder.RenameTable(
                name: "MeetingAssignmentModel",
                newName: "MeetingAssignmentModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeetingAssignmentModels",
                table: "MeetingAssignmentModels",
                column: "Id");
        }
    }
}
