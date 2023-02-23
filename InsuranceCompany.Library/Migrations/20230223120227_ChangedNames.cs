using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCompany.Library.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Kupac_KupacId",
                table: "Auto");

            migrationBuilder.DropForeignKey(
                name: "FK_Filijala_Agencija_AgencijaId",
                table: "Filijala");

            migrationBuilder.DropForeignKey(
                name: "FK_Filijala_Drzava_DrzavaId",
                table: "Filijala");

            migrationBuilder.DropForeignKey(
                name: "FK_Nesreca_Auto_AutoId",
                table: "Nesreca");

            migrationBuilder.DropForeignKey(
                name: "FK_Nesreca_Sleper_SleperId",
                table: "Nesreca");

            migrationBuilder.DropForeignKey(
                name: "FK_Sleper_SlepSluzba_SlepSluzbaId",
                table: "Sleper");

            migrationBuilder.DropForeignKey(
                name: "FK_SlepSluzba_Filijala_FilijalaId",
                table: "SlepSluzba");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlepSluzba",
                table: "SlepSluzba");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sleper",
                table: "Sleper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaketPomoci",
                table: "PaketPomoci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nesreca",
                table: "Nesreca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kupac",
                table: "Kupac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filijala",
                table: "Filijala");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drzava",
                table: "Drzava");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auto",
                table: "Auto");

            migrationBuilder.RenameTable(
                name: "SlepSluzba",
                newName: "SlepSluzbe");

            migrationBuilder.RenameTable(
                name: "Sleper",
                newName: "Sleperi");

            migrationBuilder.RenameTable(
                name: "PaketPomoci",
                newName: "PaketiPomoci");

            migrationBuilder.RenameTable(
                name: "Nesreca",
                newName: "Nesrece");

            migrationBuilder.RenameTable(
                name: "Kupac",
                newName: "Kupco");

            migrationBuilder.RenameTable(
                name: "Filijala",
                newName: "Filijale");

            migrationBuilder.RenameTable(
                name: "Drzava",
                newName: "Drzave");

            migrationBuilder.RenameTable(
                name: "Auto",
                newName: "Auti");

            migrationBuilder.RenameIndex(
                name: "IX_SlepSluzba_FilijalaId",
                table: "SlepSluzbe",
                newName: "IX_SlepSluzbe_FilijalaId");

            migrationBuilder.RenameIndex(
                name: "IX_Sleper_SlepSluzbaId",
                table: "Sleperi",
                newName: "IX_Sleperi_SlepSluzbaId");

            migrationBuilder.RenameIndex(
                name: "IX_Nesreca_SleperId",
                table: "Nesrece",
                newName: "IX_Nesrece_SleperId");

            migrationBuilder.RenameIndex(
                name: "IX_Nesreca_AutoId",
                table: "Nesrece",
                newName: "IX_Nesrece_AutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Filijala_DrzavaId",
                table: "Filijale",
                newName: "IX_Filijale_DrzavaId");

            migrationBuilder.RenameIndex(
                name: "IX_Filijala_AgencijaId",
                table: "Filijale",
                newName: "IX_Filijale_AgencijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Auto_KupacId",
                table: "Auti",
                newName: "IX_Auti_KupacId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlepSluzbe",
                table: "SlepSluzbe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sleperi",
                table: "Sleperi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaketiPomoci",
                table: "PaketiPomoci",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nesrece",
                table: "Nesrece",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kupco",
                table: "Kupco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filijale",
                table: "Filijale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drzave",
                table: "Drzave",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auti",
                table: "Auti",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Auti_Kupco_KupacId",
                table: "Auti",
                column: "KupacId",
                principalTable: "Kupco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filijale_Agencija_AgencijaId",
                table: "Filijale",
                column: "AgencijaId",
                principalTable: "Agencija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filijale_Drzave_DrzavaId",
                table: "Filijale",
                column: "DrzavaId",
                principalTable: "Drzave",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nesrece_Auti_AutoId",
                table: "Nesrece",
                column: "AutoId",
                principalTable: "Auti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nesrece_Sleperi_SleperId",
                table: "Nesrece",
                column: "SleperId",
                principalTable: "Sleperi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sleperi_SlepSluzbe_SlepSluzbaId",
                table: "Sleperi",
                column: "SlepSluzbaId",
                principalTable: "SlepSluzbe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlepSluzbe_Filijale_FilijalaId",
                table: "SlepSluzbe",
                column: "FilijalaId",
                principalTable: "Filijale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auti_Kupco_KupacId",
                table: "Auti");

            migrationBuilder.DropForeignKey(
                name: "FK_Filijale_Agencija_AgencijaId",
                table: "Filijale");

            migrationBuilder.DropForeignKey(
                name: "FK_Filijale_Drzave_DrzavaId",
                table: "Filijale");

            migrationBuilder.DropForeignKey(
                name: "FK_Nesrece_Auti_AutoId",
                table: "Nesrece");

            migrationBuilder.DropForeignKey(
                name: "FK_Nesrece_Sleperi_SleperId",
                table: "Nesrece");

            migrationBuilder.DropForeignKey(
                name: "FK_Sleperi_SlepSluzbe_SlepSluzbaId",
                table: "Sleperi");

            migrationBuilder.DropForeignKey(
                name: "FK_SlepSluzbe_Filijale_FilijalaId",
                table: "SlepSluzbe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlepSluzbe",
                table: "SlepSluzbe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sleperi",
                table: "Sleperi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaketiPomoci",
                table: "PaketiPomoci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nesrece",
                table: "Nesrece");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kupco",
                table: "Kupco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filijale",
                table: "Filijale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drzave",
                table: "Drzave");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auti",
                table: "Auti");

            migrationBuilder.RenameTable(
                name: "SlepSluzbe",
                newName: "SlepSluzba");

            migrationBuilder.RenameTable(
                name: "Sleperi",
                newName: "Sleper");

            migrationBuilder.RenameTable(
                name: "PaketiPomoci",
                newName: "PaketPomoci");

            migrationBuilder.RenameTable(
                name: "Nesrece",
                newName: "Nesreca");

            migrationBuilder.RenameTable(
                name: "Kupco",
                newName: "Kupac");

            migrationBuilder.RenameTable(
                name: "Filijale",
                newName: "Filijala");

            migrationBuilder.RenameTable(
                name: "Drzave",
                newName: "Drzava");

            migrationBuilder.RenameTable(
                name: "Auti",
                newName: "Auto");

            migrationBuilder.RenameIndex(
                name: "IX_SlepSluzbe_FilijalaId",
                table: "SlepSluzba",
                newName: "IX_SlepSluzba_FilijalaId");

            migrationBuilder.RenameIndex(
                name: "IX_Sleperi_SlepSluzbaId",
                table: "Sleper",
                newName: "IX_Sleper_SlepSluzbaId");

            migrationBuilder.RenameIndex(
                name: "IX_Nesrece_SleperId",
                table: "Nesreca",
                newName: "IX_Nesreca_SleperId");

            migrationBuilder.RenameIndex(
                name: "IX_Nesrece_AutoId",
                table: "Nesreca",
                newName: "IX_Nesreca_AutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Filijale_DrzavaId",
                table: "Filijala",
                newName: "IX_Filijala_DrzavaId");

            migrationBuilder.RenameIndex(
                name: "IX_Filijale_AgencijaId",
                table: "Filijala",
                newName: "IX_Filijala_AgencijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Auti_KupacId",
                table: "Auto",
                newName: "IX_Auto_KupacId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlepSluzba",
                table: "SlepSluzba",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sleper",
                table: "Sleper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaketPomoci",
                table: "PaketPomoci",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nesreca",
                table: "Nesreca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kupac",
                table: "Kupac",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filijala",
                table: "Filijala",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drzava",
                table: "Drzava",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auto",
                table: "Auto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Kupac_KupacId",
                table: "Auto",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filijala_Agencija_AgencijaId",
                table: "Filijala",
                column: "AgencijaId",
                principalTable: "Agencija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filijala_Drzava_DrzavaId",
                table: "Filijala",
                column: "DrzavaId",
                principalTable: "Drzava",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nesreca_Auto_AutoId",
                table: "Nesreca",
                column: "AutoId",
                principalTable: "Auto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nesreca_Sleper_SleperId",
                table: "Nesreca",
                column: "SleperId",
                principalTable: "Sleper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sleper_SlepSluzba_SlepSluzbaId",
                table: "Sleper",
                column: "SlepSluzbaId",
                principalTable: "SlepSluzba",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlepSluzba_Filijala_FilijalaId",
                table: "SlepSluzba",
                column: "FilijalaId",
                principalTable: "Filijala",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
