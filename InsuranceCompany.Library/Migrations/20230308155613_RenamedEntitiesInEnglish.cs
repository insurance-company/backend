using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class RenamedEntitiesInEnglish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenti_Radnici_Id",
                table: "Agenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_Radnici_SefId",
                table: "Radnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Radnici_Users_Id",
                table: "Radnici");

            migrationBuilder.DropTable(
                name: "Menadzeri");

            migrationBuilder.DropTable(
                name: "Nesrece");

            migrationBuilder.DropTable(
                name: "PotpisanePolise");

            migrationBuilder.DropTable(
                name: "Sleperi");

            migrationBuilder.DropTable(
                name: "Auti");

            migrationBuilder.DropTable(
                name: "Polise");

            migrationBuilder.DropTable(
                name: "SlepSluzbe");

            migrationBuilder.DropTable(
                name: "PaketiPomoci");

            migrationBuilder.DropTable(
                name: "Filijale");

            migrationBuilder.DropTable(
                name: "Agencija");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agenti",
                table: "Agenti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Radnici",
                table: "Radnici");

            migrationBuilder.DropIndex(
                name: "IX_Radnici_SefId",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "SefId",
                table: "Radnici");

            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Radnici");

            migrationBuilder.RenameTable(
                name: "Agenti",
                newName: "Agents");

            migrationBuilder.RenameTable(
                name: "Radnici",
                newName: "Workers");

            migrationBuilder.RenameColumn(
                name: "Prezime",
                table: "Users",
                newName: "UniqueMasterCitizenNumber");

            migrationBuilder.RenameColumn(
                name: "Pol",
                table: "Users",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "JMBG",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Ime",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "BrojTelefona",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Adresa",
                table: "Users",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "BrojLicence",
                table: "Agents",
                newName: "LicenceNumber");

            migrationBuilder.AddColumn<int>(
                name: "BossId",
                table: "Workers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agents",
                table: "Agents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PIB = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AidPackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DurationInMonths = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Cover = table.Column<double>(type: "double precision", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AidPackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RegisterNumber = table.Column<string>(type: "text", nullable: false),
                    Years = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AgencyId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    ManagesTheBranchId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Branches_ManagesTheBranchId",
                        column: x => x.ManagesTheBranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Managers_Workers_Id",
                        column: x => x.Id,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TowingServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Address = table.Column<string>(type: "text", nullable: false),
                    BranchId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TowingServices_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignedPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PolicyId = table.Column<int>(type: "integer", nullable: false),
                    AgentId = table.Column<int>(type: "integer", nullable: false),
                    CarId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignedPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignedPolicies_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignedPolicies_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignedPolicies_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TowTrucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Length = table.Column<double>(type: "double precision", nullable: false),
                    Width = table.Column<double>(type: "double precision", nullable: false),
                    TransportCapacity = table.Column<double>(type: "double precision", nullable: false),
                    TowingServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowTrucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TowTrucks_TowingServices_TowingServiceId",
                        column: x => x.TowingServiceId,
                        principalTable: "TowingServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CarId = table.Column<int>(type: "integer", nullable: false),
                    TowTruckId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accidents_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accidents_TowTrucks_TowTruckId",
                        column: x => x.TowTruckId,
                        principalTable: "TowTrucks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_BossId",
                table: "Workers",
                column: "BossId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidents_CarId",
                table: "Accidents",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidents_TowTruckId",
                table: "Accidents",
                column: "TowTruckId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_AgencyId",
                table: "Branches",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OwnerId",
                table: "Cars",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_ManagesTheBranchId",
                table: "Managers",
                column: "ManagesTheBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_AidPackageId",
                table: "Policies",
                column: "AidPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedPolicies_AgentId",
                table: "SignedPolicies",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedPolicies_CarId",
                table: "SignedPolicies",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedPolicies_PolicyId",
                table: "SignedPolicies",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_TowingServices_BranchId",
                table: "TowingServices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TowTrucks_TowingServiceId",
                table: "TowTrucks",
                column: "TowingServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Workers_Id",
                table: "Agents",
                column: "Id",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Users_Id",
                table: "Workers",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Workers_BossId",
                table: "Workers",
                column: "BossId",
                principalTable: "Workers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Workers_Id",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Users_Id",
                table: "Workers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Workers_BossId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Accidents");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "SignedPolicies");

            migrationBuilder.DropTable(
                name: "TowTrucks");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "TowingServices");

            migrationBuilder.DropTable(
                name: "AidPackages");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agents",
                table: "Agents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_BossId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "BossId",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Agents",
                newName: "Agenti");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Radnici");

            migrationBuilder.RenameColumn(
                name: "UniqueMasterCitizenNumber",
                table: "Users",
                newName: "Prezime");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "JMBG");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Ime");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "Pol");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "BrojTelefona");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "Adresa");

            migrationBuilder.RenameColumn(
                name: "LicenceNumber",
                table: "Agenti",
                newName: "BrojLicence");

            migrationBuilder.AddColumn<int>(
                name: "SefId",
                table: "Radnici",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tip",
                table: "Radnici",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agenti",
                table: "Agenti",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Radnici",
                table: "Radnici",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Agencija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Naziv = table.Column<string>(type: "text", nullable: false),
                    PIB = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    VlasnikId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Godiste = table.Column<int>(type: "integer", nullable: false),
                    Marka = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    RegistarskiBroj = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auti_Users_VlasnikId",
                        column: x => x.VlasnikId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaketiPomoci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Cena = table.Column<double>(type: "double precision", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Pokrice = table.Column<double>(type: "double precision", nullable: false),
                    Tip = table.Column<string>(type: "text", nullable: false),
                    TrajanjeUMesecima = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketiPomoci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filijale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AgencijaId = table.Column<int>(type: "integer", nullable: false),
                    Adresa = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filijale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filijale_Agencija_AgencijaId",
                        column: x => x.AgencijaId,
                        principalTable: "Agencija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Polise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PaketPomociId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "SlepSluzbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FilijalaId = table.Column<int>(type: "integer", nullable: false),
                    Adresa = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlepSluzbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlepSluzbe_Filijale_FilijalaId",
                        column: x => x.FilijalaId,
                        principalTable: "Filijale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PotpisanePolise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AgentId = table.Column<int>(type: "integer", nullable: false),
                    AutoId = table.Column<int>(type: "integer", nullable: false),
                    PolisaId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Datum = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotpisanePolise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PotpisanePolise_Agenti_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "Sleperi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SlepSluzbaId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Duzina = table.Column<double>(type: "double precision", nullable: false),
                    Nosivost = table.Column<double>(type: "double precision", nullable: false),
                    Sirina = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleperi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sleperi_SlepSluzbe_SlepSluzbaId",
                        column: x => x.SlepSluzbaId,
                        principalTable: "SlepSluzbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nesrece",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AutoId = table.Column<int>(type: "integer", nullable: false),
                    SleperId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Datum = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Opis = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nesrece", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nesrece_Auti_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Auti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nesrece_Sleperi_SleperId",
                        column: x => x.SleperId,
                        principalTable: "Sleperi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Radnici_SefId",
                table: "Radnici",
                column: "SefId");

            migrationBuilder.CreateIndex(
                name: "IX_Auti_VlasnikId",
                table: "Auti",
                column: "VlasnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Filijale_AgencijaId",
                table: "Filijale",
                column: "AgencijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Menadzeri_RukovodiFilijalomId",
                table: "Menadzeri",
                column: "RukovodiFilijalomId");

            migrationBuilder.CreateIndex(
                name: "IX_Nesrece_AutoId",
                table: "Nesrece",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Nesrece_SleperId",
                table: "Nesrece",
                column: "SleperId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Sleperi_SlepSluzbaId",
                table: "Sleperi",
                column: "SlepSluzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_SlepSluzbe_FilijalaId",
                table: "SlepSluzbe",
                column: "FilijalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenti_Radnici_Id",
                table: "Agenti",
                column: "Id",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_Radnici_SefId",
                table: "Radnici",
                column: "SefId",
                principalTable: "Radnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radnici_Users_Id",
                table: "Radnici",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
