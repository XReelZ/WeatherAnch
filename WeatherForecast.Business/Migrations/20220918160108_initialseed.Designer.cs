﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherForecast.Business.Data;

namespace WeatherForecast.Business.Migrations
{
    [DbContext(typeof(ForecastDbContext))]
    [Migration("20220918160108_initialseed")]
    partial class initialseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherForecast.Business.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CityID")
                        .HasName("PK_City");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            Name = "Sofia",
                            PostCode = "1000"
                        });
                });

            modelBuilder.Entity("WeatherForecast.Business.Models.Weather", b =>
                {
                    b.Property<int>("WeatherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.Property<int>("TemperatureF")
                        .HasColumnType("int");

                    b.HasKey("WeatherID")
                        .HasName("PK_Weather");

                    b.HasIndex("CityID");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            WeatherID = 1,
                            CityID = 1,
                            Date = new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Very Hot",
                            TemperatureC = 30,
                            TemperatureF = 86
                        });
                });

            modelBuilder.Entity("WeatherForecast.Business.Models.Weather", b =>
                {
                    b.HasOne("WeatherForecast.Business.Models.City", "City")
                        .WithMany("Forecast")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("WeatherForecast.Business.Models.City", b =>
                {
                    b.Navigation("Forecast");
                });
#pragma warning restore 612, 618
        }
    }
}