using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonMvc.DataAccess.Migrations
{
    public partial class RezervasyonTableMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RezervasyonHareketleri_Rezervasyonşar_RezervasyonId",
                table: "RezervasyonHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyonşar_Musteriler_MusteriId",
                table: "Rezervasyonşar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervasyonşar",
                table: "Rezervasyonşar");

            migrationBuilder.RenameTable(
                name: "Rezervasyonşar",
                newName: "Rezervasyonlar");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervasyonşar_MusteriId",
                table: "Rezervasyonlar",
                newName: "IX_Rezervasyonlar_MusteriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervasyonlar",
                table: "Rezervasyonlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RezervasyonHareketleri_Rezervasyonlar_RezervasyonId",
                table: "RezervasyonHareketleri",
                column: "RezervasyonId",
                principalTable: "Rezervasyonlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonlar_Musteriler_MusteriId",
                table: "Rezervasyonlar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RezervasyonHareketleri_Rezervasyonlar_RezervasyonId",
                table: "RezervasyonHareketleri");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyonlar_Musteriler_MusteriId",
                table: "Rezervasyonlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervasyonlar",
                table: "Rezervasyonlar");

            migrationBuilder.RenameTable(
                name: "Rezervasyonlar",
                newName: "Rezervasyonşar");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervasyonlar_MusteriId",
                table: "Rezervasyonşar",
                newName: "IX_Rezervasyonşar_MusteriId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervasyonşar",
                table: "Rezervasyonşar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RezervasyonHareketleri_Rezervasyonşar_RezervasyonId",
                table: "RezervasyonHareketleri",
                column: "RezervasyonId",
                principalTable: "Rezervasyonşar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonşar_Musteriler_MusteriId",
                table: "Rezervasyonşar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
