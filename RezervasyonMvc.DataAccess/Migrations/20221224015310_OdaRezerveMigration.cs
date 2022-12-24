using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonMvc.DataAccess.Migrations
{
    public partial class OdaRezerveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Rezerve",
                table: "Odalar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rezerve",
                table: "Odalar");
        }
    }
}
