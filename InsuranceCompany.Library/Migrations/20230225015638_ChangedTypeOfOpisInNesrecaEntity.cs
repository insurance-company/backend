using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTypeOfOpisInNesrecaEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Nesrece",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Opis",
                table: "Nesrece",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
