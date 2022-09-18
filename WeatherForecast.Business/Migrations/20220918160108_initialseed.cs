using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherForecast.Business.Migrations
{
    public partial class initialseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "Name", "PostCode" },
                values: new object[] { 1, "Sofia", "1000" });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "WeatherID", "CityID", "Date", "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Hot", 30, 86 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "WeatherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 1);
        }
    }
}
