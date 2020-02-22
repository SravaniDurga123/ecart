using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDAL.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pname = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    eid = table.Column<string>(maxLength: 5, nullable: false),
                    ename = table.Column<string>(maxLength: 30, nullable: false),
                    joindate = table.Column<DateTime>(type: "Date", nullable: true),
                    designation = table.Column<string>(maxLength: 20, nullable: true),
                    salary = table.Column<decimal>(nullable: true),
                    pid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.eid);
                    table.ForeignKey(
                        name: "FK_Employee_project_pid",
                        column: x => x.pid,
                        principalTable: "project",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_pid",
                table: "Employee",
                column: "pid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "project");
        }
    }
}
