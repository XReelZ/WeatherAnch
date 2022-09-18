using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherForecast.Business.Migrations
{
    public partial class migrationRenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "WeatherForecasts",
                newName: "WeatherID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cities",
                newName: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "WeatherForecasts",
                newName: "WeatherID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cities",
                newName: "CityID");
        }
    }
}
