using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class FixedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Users_KupacId",
                table: "Auti");

            migrationBuilder.DropForeignKey(
                name: "FK_PotpisanePolise_Users_AgentId",
                table: "PotpisanePolise");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Filijale_RukovodiFilijalomId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RukovodiFilijalomId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BrojLicence",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RukovodiFilijalomId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Users");

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

            migrationBuilder.CreateTable(
                name: "Radnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Tip = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Radnici_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    BrojLicence = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenti_Radnici_Id",
                        column: x => x.Id,
                        principalTable: "Radnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menadzeri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    RukovodiFilijalomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menadzeri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menadzeri_Filijale_RukovodiFilijalomId",
                        column: x => x.RukovodiFilijalomId,
                        principalTable: "Filijale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menadzeri_Radnici_Id",
                        column: x => x.Id,
                        principalTable: "Radnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menadzeri_RukovodiFilijalomId",
                table: "Menadzeri",
                column: "RukovodiFilijalomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Kupci_KupacId",
                table: "Auti",
                column: "KupacId",
                principalTable: "Kupci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PotpisanePolise_Agenti_AgentId",
                table: "PotpisanePolise",
                column: "AgentId",
                principalTable: "Agenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Kupci_KupacId",
                table: "Auti");

            migrationBuilder.DropForeignKey(
                name: "FK_PotpisanePolise_Agenti_AgentId",
                table: "PotpisanePolise");

            migrationBuilder.DropTable(
                name: "Agenti");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Menadzeri");

            migrationBuilder.DropTable(
                name: "Radnici");

            migrationBuilder.AddColumn<string>(
                name: "BrojLicence",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RukovodiFilijalomId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tip",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RukovodiFilijalomId",
                table: "Users",
                column: "RukovodiFilijalomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Users_KupacId",
                table: "Auti",
                column: "KupacId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PotpisanePolise_Users_AgentId",
                table: "PotpisanePolise",
                column: "AgentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Filijale_RukovodiFilijalomId",
                table: "Users",
                column: "RukovodiFilijalomId",
                principalTable: "Filijale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
