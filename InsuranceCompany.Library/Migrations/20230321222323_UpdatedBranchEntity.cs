using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBranchEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TowingServices_Branches_BranchId",
                table: "TowingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Branches_WorksInBranchId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorksInBranchId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_TowingServices_BranchId",
                table: "TowingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branches",
                table: "Branches");

            migrationBuilder.AddColumn<int>(
                name: "WorksInBranchAgencyId",
                table: "Workers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchAgencyId",
                table: "TowingServices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Branches",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branches",
                table: "Branches",
                columns: new[] { "Id", "AgencyId" });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorksInBranchId_WorksInBranchAgencyId",
                table: "Workers",
                columns: new[] { "WorksInBranchId", "WorksInBranchAgencyId" });

            migrationBuilder.CreateIndex(
                name: "IX_TowingServices_BranchId_BranchAgencyId",
                table: "TowingServices",
                columns: new[] { "BranchId", "BranchAgencyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TowingServices_Branches_BranchId_BranchAgencyId",
                table: "TowingServices",
                columns: new[] { "BranchId", "BranchAgencyId" },
                principalTable: "Branches",
                principalColumns: new[] { "Id", "AgencyId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Branches_WorksInBranchId_WorksInBranchAgencyId",
                table: "Workers",
                columns: new[] { "WorksInBranchId", "WorksInBranchAgencyId" },
                principalTable: "Branches",
                principalColumns: new[] { "Id", "AgencyId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TowingServices_Branches_BranchId_BranchAgencyId",
                table: "TowingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Branches_WorksInBranchId_WorksInBranchAgencyId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorksInBranchId_WorksInBranchAgencyId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_TowingServices_BranchId_BranchAgencyId",
                table: "TowingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branches",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "WorksInBranchAgencyId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "BranchAgencyId",
                table: "TowingServices");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Branches",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branches",
                table: "Branches",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorksInBranchId",
                table: "Workers",
                column: "WorksInBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TowingServices_BranchId",
                table: "TowingServices",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_TowingServices_Branches_BranchId",
                table: "TowingServices",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Branches_WorksInBranchId",
                table: "Workers",
                column: "WorksInBranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
