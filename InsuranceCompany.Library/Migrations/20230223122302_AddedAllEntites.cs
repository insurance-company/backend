using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllEntites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Kupco_KupacId",
                table: "Auti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kupco",
                table: "Kupco");

            migrationBuilder.RenameTable(
                name: "Kupco",
                newName: "Users");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Polise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Datum = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PaketPomociId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polise_PaketiPomoci_PaketPomociId",
                        column: x => x.PaketPomociId,
                        principalTable: "PaketiPomoci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PotpisanePolise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PolisaId = table.Column<int>(type: "integer", nullable: false),
                    AgentId = table.Column<int>(type: "integer", nullable: false),
                    AutoId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotpisanePolise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PotpisanePolise_Auti_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Auti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PotpisanePolise_Polise_PolisaId",
                        column: x => x.PolisaId,
                        principalTable: "Polise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PotpisanePolise_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RukovodiFilijalomId",
                table: "Users",
                column: "RukovodiFilijalomId");

            migrationBuilder.CreateIndex(
                name: "IX_Polise_PaketPomociId",
                table: "Polise",
                column: "PaketPomociId");

            migrationBuilder.CreateIndex(
                name: "IX_PotpisanePolise_AgentId",
                table: "PotpisanePolise",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_PotpisanePolise_AutoId",
                table: "PotpisanePolise",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_PotpisanePolise_PolisaId",
                table: "PotpisanePolise",
                column: "PolisaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Users_KupacId",
                table: "Auti",
                column: "KupacId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Users_KupacId",
                table: "Auti");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Filijale_RukovodiFilijalomId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "PotpisanePolise");

            migrationBuilder.DropTable(
                name: "Polise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
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

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Kupco");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kupco",
                table: "Kupco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Kupco_KupacId",
                table: "Auti",
                column: "KupacId",
                principalTable: "Kupco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
