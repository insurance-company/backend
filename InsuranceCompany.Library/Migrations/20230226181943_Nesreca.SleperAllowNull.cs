using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class NesrecaSleperAllowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nesrece_Sleperi_SleperId",
                table: "Nesrece");

            migrationBuilder.AlterColumn<int>(
                name: "SleperId",
                table: "Nesrece",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Nesrece_Sleperi_SleperId",
                table: "Nesrece",
                column: "SleperId",
                principalTable: "Sleperi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nesrece_Sleperi_SleperId",
                table: "Nesrece");

            migrationBuilder.AlterColumn<int>(
                name: "SleperId",
                table: "Nesrece",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nesrece_Sleperi_SleperId",
                table: "Nesrece",
                column: "SleperId",
                principalTable: "Sleperi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
