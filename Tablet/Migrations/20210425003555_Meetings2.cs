using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Meetings2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeetingId",
                table: "MeetingModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "MeetingModel");
        }
    }
}
