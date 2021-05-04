using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Restrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RestrictionsModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: true),
                    RedLine = table.Column<string>(nullable: true),
                    Finance = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    Architecture = table.Column<string>(nullable: true),
                    Safety = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true),
                    Infrastructure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestrictionsModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestrictionsModel");
        }
    }
}
