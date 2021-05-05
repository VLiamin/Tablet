using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Index : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralDevelopmentModels",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Forecast = table.Column<int>(nullable: false),
                    Progress = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralDevelopmentModels", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ListOfMeetingsModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    ProjectId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfMeetingsModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingAssignmentModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Asignment = table.Column<string>(nullable: true),
                    RedLine = table.Column<DateTime>(nullable: false),
                    Responsible = table.Column<string>(nullable: true),
                    MeetingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingAssignmentModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Question = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Suggestion = table.Column<string>(nullable: true),
                    MeetingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    Developer = table.Column<string>(nullable: true),
                    Technology = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectGeneralProblems",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Project = table.Column<string>(nullable: true)
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
                    Persent = table.Column<string>(nullable: true),
                    Project = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGeneralWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProblems",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Project = table.Column<string>(nullable: true),
                    Problem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProblems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRisks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RedLine = table.Column<DateTime>(nullable: false),
                    OTV = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    Project = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRisks", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Project = table.Column<string>(nullable: true),
                    Stage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Proportion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralDevelopmentModels");

            migrationBuilder.DropTable(
                name: "InformationModel");

            migrationBuilder.DropTable(
                name: "ListOfMeetingsModel");

            migrationBuilder.DropTable(
                name: "MeetingAssignmentModel");

            migrationBuilder.DropTable(
                name: "MeetingModel");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ProjectGeneralProblems");

            migrationBuilder.DropTable(
                name: "ProjectGeneralWorks");

            migrationBuilder.DropTable(
                name: "ProjectProblems");

            migrationBuilder.DropTable(
                name: "ProjectRisks");

            migrationBuilder.DropTable(
                name: "RestrictionsModel");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
