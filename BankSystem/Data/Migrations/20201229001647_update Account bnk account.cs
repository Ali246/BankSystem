using Microsoft.EntityFrameworkCore.Migrations;

namespace BankSystem.Data.Migrations
{
    public partial class updateAccountbnkaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bank_bankaccount_BankAccountId",
                table: "bank");

            migrationBuilder.DropIndex(
                name: "IX_bank_BankAccountId",
                table: "bank");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "bankaccount");

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "bank");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "bankaccount",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_bankaccount_BankId",
                table: "bankaccount",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_bankaccount_CurrencyId",
                table: "bankaccount",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_bankaccount_bank_BankId",
                table: "bankaccount",
                column: "BankId",
                principalTable: "bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bankaccount_currency_CurrencyId",
                table: "bankaccount",
                column: "CurrencyId",
                principalTable: "currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankaccount_bank_BankId",
                table: "bankaccount");

            migrationBuilder.DropForeignKey(
                name: "FK_bankaccount_currency_CurrencyId",
                table: "bankaccount");

            migrationBuilder.DropIndex(
                name: "IX_bankaccount_BankId",
                table: "bankaccount");

            migrationBuilder.DropIndex(
                name: "IX_bankaccount_CurrencyId",
                table: "bankaccount");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "bankaccount");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "bankaccount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BankAccountId",
                table: "bank",
                type: "int",
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
    }
}
