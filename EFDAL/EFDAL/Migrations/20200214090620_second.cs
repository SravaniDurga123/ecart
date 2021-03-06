﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDAL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "enddate",
                table: "project",
                type: "Date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "startdate",
                table: "project",
                type: "Date",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enddate",
                table: "project");

            migrationBuilder.DropColumn(
                name: "startdate",
                table: "project");
        }
    }
}
