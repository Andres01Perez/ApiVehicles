using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Migrations
{
    public partial class errorsFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Line",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Procedures");

            migrationBuilder.RenameColumn(
                name: "Plaque",
                table: "Vehicles",
                newName: "Placa");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Procedures",
                newName: "description");

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Procedures",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Procedures");

            migrationBuilder.RenameColumn(
                name: "Placa",
                table: "Vehicles",
                newName: "Plaque");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Procedures",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Line",
                table: "Vehicles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Procedures",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
