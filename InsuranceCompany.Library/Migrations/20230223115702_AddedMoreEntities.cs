using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RegistarskiBroj = table.Column<string>(type: "text", nullable: false),
                    Godiste = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Marka = table.Column<string>(type: "text", nullable: false),
                    KupacId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auto_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filijala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AgencijaId = table.Column<int>(type: "integer", nullable: false),
                    Adresa = table.Column<string>(type: "text", nullable: false),
                    DrzavaId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filijala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filijala_Agencija_AgencijaId",
                        column: x => x.AgencijaId,
                        principalTable: "Agencija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Filijala_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaketPomoci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TrajanjeUMesecima = table.Column<int>(type: "integer", nullable: false),
                    Cena = table.Column<double>(type: "double precision", nullable: false),
                    Tip = table.Column<string>(type: "text", nullable: false),
                    Pokrice = table.Column<double>(type: "double precision", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketPomoci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlepSluzba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Adresa = table.Column<string>(type: "text", nullable: false),
                    FilijalaId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlepSluzba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlepSluzba_Filijala_FilijalaId",
                        column: x => x.FilijalaId,
                        principalTable: "Filijala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sleper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Duzina = table.Column<double>(type: "double precision", nullable: false),
                    Sirina = table.Column<double>(type: "double precision", nullable: false),
                    Nosivost = table.Column<double>(type: "double precision", nullable: false),
                    SlepSluzbaId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sleper_SlepSluzba_SlepSluzbaId",
                        column: x => x.SlepSluzbaId,
                        principalTable: "SlepSluzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nesreca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Opis = table.Column<int>(type: "integer", nullable: false),
                    Datum = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AutoId = table.Column<int>(type: "integer", nullable: false),
                    SleperId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nesreca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nesreca_Auto_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Auto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nesreca_Sleper_SleperId",
                        column: x => x.SleperId,
                        principalTable: "Sleper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_KupacId",
                table: "Auto",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Filijala_AgencijaId",
                table: "Filijala",
                column: "AgencijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Filijala_DrzavaId",
                table: "Filijala",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nesreca_AutoId",
                table: "Nesreca",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Nesreca_SleperId",
                table: "Nesreca",
                column: "SleperId");

            migrationBuilder.CreateIndex(
                name: "IX_Sleper_SlepSluzbaId",
                table: "Sleper",
                column: "SlepSluzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_SlepSluzba_FilijalaId",
                table: "SlepSluzba",
                column: "FilijalaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nesreca");

            migrationBuilder.DropTable(
                name: "PaketPomoci");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Sleper");

            migrationBuilder.DropTable(
                name: "SlepSluzba");

            migrationBuilder.DropTable(
                name: "Filijala");
        }
    }
}
