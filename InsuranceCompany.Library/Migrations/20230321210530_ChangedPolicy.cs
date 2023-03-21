using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPolicy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidents_SignedPolicies_PolicyId",
                table: "Accidents");

            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_Agents_AgentId",
                table: "SignedPolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_AidPackages_AidPackageId",
                table: "SignedPolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_Cars_CarId",
                table: "SignedPolicies");

            migrationBuilder.DropIndex(
                name: "IX_Accidents_PolicyId",
                table: "Accidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SignedPolicies",
                table: "SignedPolicies");

            migrationBuilder.DropIndex(
                name: "IX_SignedPolicies_AidPackageId",
                table: "SignedPolicies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SignedPolicies");

            migrationBuilder.RenameTable(
                name: "SignedPolicies",
                newName: "Policies");

            migrationBuilder.RenameColumn(
                name: "PolicyId",
                table: "Accidents",
                newName: "PolicyCarId");

            migrationBuilder.RenameIndex(
                name: "IX_SignedPolicies_CarId",
                table: "Policies",
                newName: "IX_Policies_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_SignedPolicies_AgentId",
                table: "Policies",
                newName: "IX_Policies_AgentId");

            migrationBuilder.AddColumn<int>(
                name: "PolicyAidPackageId",
                table: "Accidents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Policies",
                table: "Policies",
                columns: new[] { "AidPackageId", "CarId" });

            migrationBuilder.CreateIndex(
                name: "IX_Accidents_PolicyAidPackageId_PolicyCarId",
                table: "Accidents",
                columns: new[] { "PolicyAidPackageId", "PolicyCarId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Accidents_Policies_PolicyAidPackageId_PolicyCarId",
                table: "Accidents",
                columns: new[] { "PolicyAidPackageId", "PolicyCarId" },
                principalTable: "Policies",
                principalColumns: new[] { "AidPackageId", "CarId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Agents_AgentId",
                table: "Policies",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_AidPackages_AidPackageId",
                table: "Policies",
                column: "AidPackageId",
                principalTable: "AidPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Cars_CarId",
                table: "Policies",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidents_Policies_PolicyAidPackageId_PolicyCarId",
                table: "Accidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Agents_AgentId",
                table: "Policies");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_AidPackages_AidPackageId",
                table: "Policies");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Cars_CarId",
                table: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Accidents_PolicyAidPackageId_PolicyCarId",
                table: "Accidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Policies",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "PolicyAidPackageId",
                table: "Accidents");

            migrationBuilder.RenameTable(
                name: "Policies",
                newName: "SignedPolicies");

            migrationBuilder.RenameColumn(
                name: "PolicyCarId",
                table: "Accidents",
                newName: "PolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_Policies_CarId",
                table: "SignedPolicies",
                newName: "IX_SignedPolicies_CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Policies_AgentId",
                table: "SignedPolicies",
                newName: "IX_SignedPolicies_AgentId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SignedPolicies",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignedPolicies",
                table: "SignedPolicies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Accidents_PolicyId",
                table: "Accidents",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedPolicies_AidPackageId",
                table: "SignedPolicies",
                column: "AidPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidents_SignedPolicies_PolicyId",
                table: "Accidents",
                column: "PolicyId",
                principalTable: "SignedPolicies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignedPolicies_Agents_AgentId",
                table: "SignedPolicies",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SignedPolicies_AidPackages_AidPackageId",
                table: "SignedPolicies",
                column: "AidPackageId",
                principalTable: "AidPackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignedPolicies_Cars_CarId",
                table: "SignedPolicies",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
