using Microsoft.EntityFrameworkCore.Migrations;

namespace JetSkyAirlines.Data.Migrations
{
    public partial class changedluggagecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_AspNetUsers_ApplicationUserId1",
                table: "Luggages");

            migrationBuilder.DropIndex(
                name: "IX_Luggages_ApplicationUserId1",
                table: "Luggages");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Luggages");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Luggages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_ApplicationUserId",
                table: "Luggages",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_AspNetUsers_ApplicationUserId",
                table: "Luggages",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_AspNetUsers_ApplicationUserId",
                table: "Luggages");

            migrationBuilder.DropIndex(
                name: "IX_Luggages_ApplicationUserId",
                table: "Luggages");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Luggages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Luggages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_ApplicationUserId1",
                table: "Luggages",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_AspNetUsers_ApplicationUserId1",
                table: "Luggages",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
