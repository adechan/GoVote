﻿// <auto-generated />
using System;
using GoVote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoVote.Migrations.CandidateDatabase
{
    [DbContext(typeof(CandidateDatabaseContext))]
    partial class CandidateDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoVote.Data.Candidate", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PartyID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            ID = new Guid("df1a0979-f3d5-475a-b67a-529b30d481bc"),
                            FirstName = "Kat",
                            LastName = "Kitty",
                            PartyID = new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842")
                        },
                        new
                        {
                            ID = new Guid("3a727820-76a9-4ae6-a465-260ea87a56a0"),
                            FirstName = "Bobby",
                            LastName = "Doggy",
                            PartyID = new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
