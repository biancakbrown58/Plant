﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Plant;

namespace Plant.Migrations
{
    [DbContext(typeof(PlantsContext))]
    [Migration("20200226190436_AddedPlantTable")]
    partial class AddedPlantTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Plant.Plants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LastWateredDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("LightNeeded")
                        .HasColumnType("boolean");

                    b.Property<string>("LocatedPlanted")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("PlantedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("WaterNeeded")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Plant");
                });
#pragma warning restore 612, 618
        }
    }
}