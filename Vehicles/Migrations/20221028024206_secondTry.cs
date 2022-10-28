using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Migrations
{
    public partial class secondTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Brands",
                newName: "nombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Brands",
                newName: "Description");
        }
    }
}
