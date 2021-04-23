using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Tale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectGeneralProblems",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGeneralProblems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectGeneralWorks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RedLine = table.Column<DateTime>(nullable: false),
                    Responsible = table.Column<string>(nullable: true),
                    Persent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGeneralWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRisks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RedLine = table.Column<DateTime>(nullable: false),
                    OTV = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRisks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectGeneralProblems");

            migrationBuilder.DropTable(
                name: "ProjectGeneralWorks");

            migrationBuilder.DropTable(
                name: "ProjectRisks");
        }
    }
}
