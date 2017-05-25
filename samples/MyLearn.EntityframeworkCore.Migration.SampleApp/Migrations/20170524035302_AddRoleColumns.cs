using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLearn.EntityframeworkCore.Migrations.SampleApp.Migrations
{
    public partial class AddRoleColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "PlmRole",
                nullable: false,
                defaultValue: "1000-01-01 00:00:00");

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "PlmRole",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "PlmRole");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "PlmRole");
        }
    }
}
