using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankSystem.Data.Migrations
{
    public partial class addmodifieddateonbank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "modifiedDate",
                table: "bank",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modifiedDate",
                table: "bank");
        }
    }
}
