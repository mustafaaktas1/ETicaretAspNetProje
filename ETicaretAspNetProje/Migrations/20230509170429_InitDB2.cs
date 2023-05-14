using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaretAspNetProje.Migrations
{
    public partial class InitDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "Musteriler",
                newName: "Durum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Durum",
                table: "Musteriler",
                newName: "Aciklama");
        }
    }
}
