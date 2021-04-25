using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Meeting3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ListOfMeetings",
                table: "ListOfMeetings");

            migrationBuilder.RenameTable(
                name: "ListOfMeetings",
                newName: "ListOfMeetingsModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListOfMeetingsModel",
                table: "ListOfMeetingsModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ListOfMeetingsModel",
                table: "ListOfMeetingsModel");

            migrationBuilder.RenameTable(
                name: "ListOfMeetingsModel",
                newName: "ListOfMeetings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListOfMeetings",
                table: "ListOfMeetings",
                column: "Id");
        }
    }
}
