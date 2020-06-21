using Microsoft.EntityFrameworkCore.Migrations;

namespace JetSkyAirlines.Data.Migrations
{
    public partial class Changedflightcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Airplanes_AirplaneId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Airports_FromAirportId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Airports_ToAirportId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_AirplaneId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_FromAirportId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_ToAirportId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AirplaneId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FromAirportId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ToAirportId",
                table: "Flights");

            migrationBuilder.AddColumn<int>(
                name: "Airplane",
                table: "Flights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FromAirport",
                table: "Flights",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToAirport",
                table: "Flights",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Airplane",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FromAirport",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ToAirport",
                table: "Flights");

            migrationBuilder.AddColumn<int>(
                name: "AirplaneId",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromAirportId",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToAirportId",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirplaneId",
                table: "Flights",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_FromAirportId",
                table: "Flights",
                column: "FromAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ToAirportId",
                table: "Flights",
                column: "ToAirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Airplanes_AirplaneId",
                table: "Flights",
                column: "AirplaneId",
                principalTable: "Airplanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Airports_FromAirportId",
                table: "Flights",
                column: "FromAirportId",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Airports_ToAirportId",
                table: "Flights",
                column: "ToAirportId",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
