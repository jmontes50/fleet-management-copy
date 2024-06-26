﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webapi;

#nullable disable

namespace impl_fleet_management_api_csharp.Migrations
{
    [DbContext(typeof(TaxisContext))]
    partial class TaxisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Taxi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.HasKey("Id");

                    b.ToTable("Taxis", (string)null);
                });

            modelBuilder.Entity("webapi.Models.Trajectory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<Guid>("TaxiId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TaxiId");

                    b.ToTable("Trajectory", (string)null);
                });

            modelBuilder.Entity("webapi.Models.Trajectory", b =>
                {
                    b.HasOne("Taxi", "Taxi")
                        .WithMany("Trajectories")
                        .HasForeignKey("TaxiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taxi");
                });

            modelBuilder.Entity("Taxi", b =>
                {
                    b.Navigation("Trajectories");
                });
#pragma warning restore 612, 618
        }
    }
}
