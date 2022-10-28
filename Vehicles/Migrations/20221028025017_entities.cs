using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Migrations
{
    public partial class entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Vehicles_VehicleId",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "LaborPrice",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "SparePartsPrice",
                table: "Details");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Histories",
                newName: "vehicleId");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "Histories",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Histories",
                newName: "fecha");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_VehicleId",
                table: "Histories",
                newName: "IX_Histories_vehicleId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "DocumentTypes",
                newName: "nombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Vehicles_vehicleId",
                table: "Histories",
                column: "vehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Vehicles_vehicleId",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "vehicleId",
                table: "Histories",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Histories",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Histories",
                newName: "Remarks");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_vehicleId",
                table: "Histories",
                newName: "IX_Histories_VehicleId");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "DocumentTypes",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "LaborPrice",
                table: "Details",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SparePartsPrice",
                table: "Details",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Vehicles_VehicleId",
                table: "Histories",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
