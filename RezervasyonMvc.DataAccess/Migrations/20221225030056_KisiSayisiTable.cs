using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonMvc.DataAccess.Migrations
{
    public partial class KisiSayisiTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KişiSayisi",
                table: "Rezervasyonlar",
                newName: "KisiSayisi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KisiSayisi",
                table: "Rezervasyonlar",
                newName: "KişiSayisi");
        }
    }
}
