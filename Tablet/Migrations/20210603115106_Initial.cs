using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tablet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Question = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Suggestion = table.Column<string>(nullable: true),
                    MeetingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                });

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
                name: "MeetingAssignmentModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    ProjectId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    Customer = table.Column<string>(maxLength: 20, nullable: true),
                    Developer = table.Column<string>(maxLength: 20, nullable: true),
                    Technology = table.Column<string>(maxLength: 10, nullable: true),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestrictionsModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProjectId = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
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
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
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
                name: "ProjectGeneralProblems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ProjectId = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGeneralProblems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectGeneralProblems_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectGeneralWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RedLine = table.Column<DateTime>(nullable: false),
                    Responsible = table.Column<string>(nullable: true),
                    Persent = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGeneralWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectGeneralWorks_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProblems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ProjectId = table.Column<string>(maxLength: 20, nullable: true),
                    Problem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProblems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProblems_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRisks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    RedLine = table.Column<DateTime>(nullable: false),
                    OTV = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRisks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectRisks_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<string>(maxLength: 20, nullable: true),
                    Stage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stages_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGeneralProblems_ProjectId",
                table: "ProjectGeneralProblems",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGeneralWorks_ProjectId",
                table: "ProjectGeneralWorks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProblems_ProjectId",
                table: "ProjectProblems",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRisks_ProjectId",
                table: "ProjectRisks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Stages_ProjectId",
                table: "Stages",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "GeneralDevelopmentModels");

            migrationBuilder.DropTable(
                name: "InformationModel");

            migrationBuilder.DropTable(
                name: "MeetingAssignmentModel");

            migrationBuilder.DropTable(
                name: "MeetingModel");

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

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
