using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmallCompany.Models.Migrations
{
    /// <inheritdoc />
    public partial class PartnerChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partners_ContactPersons_ContactPersonId",
                table: "Partners");

            migrationBuilder.DropIndex(
                name: "IX_Partners_ContactPersonId",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "ContactPersonId",
                table: "Partners");

            migrationBuilder.AddColumn<int>(
                name: "PartnerId",
                table: "ContactPersons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactPersons_PartnerId",
                table: "ContactPersons",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPersons_Partners_PartnerId",
                table: "ContactPersons",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactPersons_Partners_PartnerId",
                table: "ContactPersons");

            migrationBuilder.DropIndex(
                name: "IX_ContactPersons_PartnerId",
                table: "ContactPersons");

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "ContactPersons");

            migrationBuilder.AddColumn<int>(
                name: "ContactPersonId",
                table: "Partners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partners_ContactPersonId",
                table: "Partners",
                column: "ContactPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_ContactPersons_ContactPersonId",
                table: "Partners",
                column: "ContactPersonId",
                principalTable: "ContactPersons",
                principalColumn: "Id");
        }
    }
}
