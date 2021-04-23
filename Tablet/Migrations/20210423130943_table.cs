using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Project",
                table: "ProjectRisks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Project",
                table: "ProjectGeneralWorks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Project",
                table: "ProjectGeneralProblems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Project",
                table: "ProjectRisks");

            migrationBuilder.DropColumn(
                name: "Project",
                table: "ProjectGeneralWorks");

            migrationBuilder.DropColumn(
                name: "Project",
                table: "ProjectGeneralProblems");
        }
    }
}
