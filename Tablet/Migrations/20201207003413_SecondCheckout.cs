using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class SecondCheckout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "technology",
                table: "Project",
                newName: "Technology");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Project",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "developer",
                table: "Project",
                newName: "Developer");

            migrationBuilder.RenameColumn(
                name: "customer",
                table: "Project",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "cost",
                table: "Project",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Project",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Technology",
                table: "Project",
                newName: "technology");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Project",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Developer",
                table: "Project",
                newName: "developer");

            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "Project",
                newName: "customer");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Project",
                newName: "cost");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Project",
                newName: "id");
        }
    }
}
