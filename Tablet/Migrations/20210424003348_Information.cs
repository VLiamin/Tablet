using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Information : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformationModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Information = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformationModel");
        }
    }
}
