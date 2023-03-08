using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPolicyEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_Agents_AgentId",
                table: "SignedPolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_Policies_PolicyId",
                table: "SignedPolicies");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.RenameColumn(
                name: "PolicyId",
                table: "SignedPolicies",
                newName: "AidPackageId");

            migrationBuilder.RenameIndex(
                name: "IX_SignedPolicies_PolicyId",
                table: "SignedPolicies",
                newName: "IX_SignedPolicies_AidPackageId");

            migrationBuilder.AlterColumn<int>(
                name: "AgentId",
                table: "SignedPolicies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_Agents_AgentId",
                table: "SignedPolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_SignedPolicies_AidPackages_AidPackageId",
                table: "SignedPolicies");

            migrationBuilder.RenameColumn(
                name: "AidPackageId",
                table: "SignedPolicies",
                newName: "PolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_SignedPolicies_AidPackageId",
                table: "SignedPolicies",
                newName: "IX_SignedPolicies_PolicyId");

            migrationBuilder.AlterColumn<int>(
                name: "AgentId",
                table: "SignedPolicies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AidPackageId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Policies_AidPackages_AidPackageId",
                        column: x => x.AidPackageId,
                        principalTable: "AidPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_AidPackageId",
                table: "Policies",
                column: "AidPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_SignedPolicies_Agents_AgentId",
                table: "SignedPolicies",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignedPolicies_Policies_PolicyId",
                table: "SignedPolicies",
                column: "PolicyId",
                principalTable: "Policies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
