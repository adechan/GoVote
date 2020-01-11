﻿// <auto-generated />
using System;
using GoVote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoVote.Migrations
{
    [DbContext(typeof(CitizenDatabaseContext))]
    [Migration("20200111104110_CitizenData1")]
    partial class CitizenData1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoVote.Data.Citizen", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VotedFor")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Citizens");

                    b.HasData(
                        new
                        {
                            ID = new Guid("fb8bb7b7-30ff-47b0-887f-f36a6ac298fa"),
                            Address = "Prelungirea Salciei nr 11",
                            CNP = "6000611068050",
                            City = "Bacau",
                            County = "Bacau",
                            FirstName = "Andreea",
                            LastName = "Rindasu",
                            Sex = "Female",
                            VotedFor = new Guid("3a727820-76a9-4ae6-a465-260ea87a56a0")
                        },
                        new
                        {
                            ID = new Guid("5430c9fc-122f-419b-94f8-d3089675855c"),
                            Address = "Trandafirilor nr 19",
                            CNP = "2940306114529",
                            City = "Iasi",
                            County = "Iasi",
                            FirstName = "Andreea",
                            LastName = "Arsene",
                            Sex = "Female",
                            VotedFor = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
