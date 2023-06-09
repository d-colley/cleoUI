﻿// <auto-generated />
using System;
using CleoUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleoUI.Migrations
{
    [DbContext(typeof(CleoUIDbContext))]
    partial class CleoUIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CleoUI.Models.Instrument", b =>
                {
                    b.Property<int>("InstrumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstrumentID"), 1L, 1);

                    b.Property<string>("InstrumentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstrumentID");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("CleoUI.Models.InstrumentResult", b =>
                {
                    b.Property<int>("ResultID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultID"), 1L, 1);

                    b.Property<int>("InstrumentID")
                        .HasColumnType("int");

                    b.Property<string>("MonthlyResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("WeeklyResult")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("ResultID");

                    b.ToTable("InstrumentResults");
                });
#pragma warning restore 612, 618
        }
    }
}
