using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFieldCarToSignedPolicyInAccidentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidents_Cars_CarId",
                table: "Accidents");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Accidents",
                newName: "PolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidents_CarId",
                table: "Accidents",
                newName: "IX_Accidents_PolicyId");

            migrationBuilder.AlterColumn<string>(
                name: "PIB",
                table: "Agencies",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidents_SignedPolicies_PolicyId",
                table: "Accidents",
                column: "PolicyId",
                principalTable: "SignedPolicies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidents_SignedPolicies_PolicyId",
                table: "Accidents");

            migrationBuilder.RenameColumn(
                name: "PolicyId",
                table: "Accidents",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidents_PolicyId",
                table: "Accidents",
                newName: "IX_Accidents_CarId");

            migrationBuilder.AlterColumn<string>(
                name: "PIB",
                table: "Agencies",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidents_Cars_CarId",
                table: "Accidents",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
