using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherForecast.Business.Migrations
{
    public partial class changeForecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "WeatherForecasts");

            migrationBuilder.RenameColumn(
                name: "TemperatureF",
                table: "WeatherForecasts",
                newName: "TemperatureMin");

            migrationBuilder.RenameColumn(
                name: "TemperatureC",
                table: "WeatherForecasts",
                newName: "TemperatureMax");

            migrationBuilder.AddColumn<float>(
                name: "RainChancePerc",
                table: "WeatherForecasts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "WeatherForecasts",
                keyColumn: "WeatherID",
                keyValue: 1,
                columns: new[] { "RainChancePerc", "TemperatureMax", "TemperatureMin" },
                values: new object[] { 0.38f, 32, 22 });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "WeatherID", "CityID", "Date", "RainChancePerc", "TemperatureMax", "TemperatureMin" },
                values: new object[] { 3, 1, new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.83f, 17, 6 });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "WeatherID", "CityID", "Date", "RainChancePerc", "TemperatureMax", "TemperatureMin" },
                values: new object[] { 2, 1, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.49f, 23, 12 });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "WeatherID", "CityID", "Date", "RainChancePerc", "TemperatureMax", "TemperatureMin" },
                values: new object[] { 1, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.38f, 32, 22 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "WeatherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "WeatherID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "RainChancePerc",
                table: "WeatherForecasts");

            migrationBuilder.RenameColumn(
                name: "TemperatureMin",
                table: "WeatherForecasts",
                newName: "TemperatureF");

            migrationBuilder.RenameColumn(
                name: "TemperatureMax",
                table: "WeatherForecasts",
                newName: "TemperatureC");

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "WeatherForecasts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Cities",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "WeatherForecasts",
                keyColumn: "WeatherID",
                keyValue: 1,
                columns: new[] { "Summary", "TemperatureC", "TemperatureF" },
                values: new object[] { "Very Hot", 30, 86 });
        }
    }
}
