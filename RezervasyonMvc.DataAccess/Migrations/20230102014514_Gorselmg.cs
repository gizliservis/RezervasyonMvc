using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonMvc.DataAccess.Migrations
{
    public partial class Gorselmg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gorsel",
                table: "Stoklar",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gorsel",
                table: "Stoklar");
        }
    }
}
