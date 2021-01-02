using Microsoft.EntityFrameworkCore.Migrations;

namespace BankSystem.Data.Migrations
{
    public partial class contactupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contact_agency_AgencyId",
                table: "contact");

            migrationBuilder.DropForeignKey(
                name: "FK_contact_bank_BankId",
                table: "contact");

            migrationBuilder.DropIndex(
                name: "IX_contact_AgencyId",
                table: "contact");

            migrationBuilder.DropIndex(
                name: "IX_contact_BankId",
                table: "contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_contact_AgencyId",
                table: "contact",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_contact_BankId",
                table: "contact",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_contact_agency_AgencyId",
                table: "contact",
                column: "AgencyId",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contact_bank_BankId",
                table: "contact",
                column: "BankId",
                principalTable: "bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
