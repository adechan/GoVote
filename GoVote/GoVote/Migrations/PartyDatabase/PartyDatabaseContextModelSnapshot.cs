﻿// <auto-generated />
using System;
using GoVote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoVote.Migrations.PartyDatabase
{
    [DbContext(typeof(PartyDatabaseContext))]
    partial class PartyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoVote.Data.Party", b =>
                {
                    b.Property<Guid>("PartyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PartyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartyID");

                    b.ToTable("Parties");

                    b.HasData(
                        new
                        {
                            PartyID = new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"),
                            PartyName = "Cool Cats Political Party"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}