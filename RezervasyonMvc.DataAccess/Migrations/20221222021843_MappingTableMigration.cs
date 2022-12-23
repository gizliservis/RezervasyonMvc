using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonMvc.DataAccess.Migrations
{
    public partial class MappingTableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "ToplamOdaFiyati",
                table: "RezervasyonHareketleri",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "OdaNo",
                table: "Odalar",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OdaFiyat",
                table: "Odalar",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "TcNo",
                table: "Musteriler",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriSoyadi",
                table: "Musteriler",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriAdi",
                table: "Musteriler",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresi",
                table: "Musteriler",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RezToplamTutar",
                table: "Rezervasyonşar",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RezToplamTutar",
                table: "Rezervasyonşar");

            migrationBuilder.RenameTable(
                name: "Rezervasyonşar",
                newName: "Rezervasyonlar");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervasyonşar_MusteriId",
                table: "Rezervasyonlar",
                newName: "IX_Rezervasyonlar_MusteriId");

            migrationBuilder.AlterColumn<decimal>(
                name: "ToplamOdaFiyati",
                table: "RezervasyonHareketleri",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "OdaNo",
                table: "Odalar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OdaFiyat",
                table: "Odalar",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "TcNo",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriSoyadi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MusteriAdi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresi",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

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
    }
}
