using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Structure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_generalDevelopmentModels",
                table: "generalDevelopmentModels");

            migrationBuilder.RenameTable(
                name: "generalDevelopmentModels",
                newName: "GeneralDevelopmentModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralDevelopmentModels",
                table: "GeneralDevelopmentModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Proportion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralDevelopmentModels",
                table: "GeneralDevelopmentModels");

            migrationBuilder.RenameTable(
                name: "GeneralDevelopmentModels",
                newName: "generalDevelopmentModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_generalDevelopmentModels",
                table: "generalDevelopmentModels",
                column: "Id");
        }
    }
}
