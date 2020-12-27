using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankSystem.Data.Migrations
{
    public partial class updateonbank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "bank",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "bank",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "bank",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "bank");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "bank");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "bank");
        }
    }
}
