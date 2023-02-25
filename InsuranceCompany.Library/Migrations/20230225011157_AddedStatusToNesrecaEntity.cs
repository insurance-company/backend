using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedStatusToNesrecaEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencija_Agencija_NadredjenaAgencijaId",
                table: "Agencija");

            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Kupci_KupacId",
                table: "Auti");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropIndex(
                name: "IX_Agencija_NadredjenaAgencijaId",
                table: "Agencija");

            migrationBuilder.DropColumn(
                name: "NadredjenaAgencijaId",
                table: "Agencija");

            migrationBuilder.RenameColumn(
                name: "KupacId",
                table: "Auti",
                newName: "VlasnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Auti_KupacId",
                table: "Auti",
                newName: "IX_Auti_VlasnikId");

            migrationBuilder.AddColumn<int>(
                name: "SefId",
                table: "Radnici",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Nesrece",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Radnici_SefId",
                table: "Radnici",
                column: "SefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Users_VlasnikId",
                table: "Auti",
                column: "VlasnikId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_Radnici_SefId",
                table: "Radnici",
                column: "SefId",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Users_VlasnikId",
                table: "Auti");

            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_Radnici_SefId",
                table: "Radnici");

            migrationBuilder.DropIndex(
                name: "IX_Radnici_SefId",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "SefId",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Nesrece");

            migrationBuilder.RenameColumn(
                name: "VlasnikId",
                table: "Auti",
                newName: "KupacId");

            migrationBuilder.RenameIndex(
                name: "IX_Auti_VlasnikId",
                table: "Auti",
                newName: "IX_Auti_KupacId");

            migrationBuilder.AddColumn<int>(
                name: "NadredjenaAgencijaId",
                table: "Agencija",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupci_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agencija_NadredjenaAgencijaId",
                table: "Agencija",
                column: "NadredjenaAgencijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencija_Agencija_NadredjenaAgencijaId",
                table: "Agencija",
                column: "NadredjenaAgencijaId",
                principalTable: "Agencija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Kupci_KupacId",
                table: "Auti",
                column: "KupacId",
                principalTable: "Kupci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
