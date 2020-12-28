using Microsoft.EntityFrameworkCore.Migrations;

namespace BankSystem.Data.Migrations
{
    public partial class updatebankaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankAccountId",
                table: "bank",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bank_BankAccountId",
                table: "bank",
                column: "BankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_bank_bankaccount_BankAccountId",
                table: "bank",
                column: "BankAccountId",
                principalTable: "bankaccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bank_bankaccount_BankAccountId",
                table: "bank");

            migrationBuilder.DropIndex(
                name: "IX_bank_BankAccountId",
                table: "bank");

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "bank");
        }
    }
}
