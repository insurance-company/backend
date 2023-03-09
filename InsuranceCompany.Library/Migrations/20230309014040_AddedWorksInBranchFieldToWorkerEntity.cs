using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedWorksInBranchFieldToWorkerEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorksInBranchId",
                table: "Workers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorksInBranchId",
                table: "Workers",
                column: "WorksInBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Branches_WorksInBranchId",
                table: "Workers",
                column: "WorksInBranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Branches_WorksInBranchId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorksInBranchId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorksInBranchId",
                table: "Workers");
        }
    }
}
