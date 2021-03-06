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

                    b.Property<Guid>("VotingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            ID = new Guid("799eca60-bb52-4fe5-ad9d-1792f7d3e809"),
                            FirstName = "Kat",
                            LastName = "Kitty",
                            PartyID = new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"),
                            VotingTypeId = new Guid("ae040cc6-c820-4f54-8173-0510907c04ee")
                        },
                        new
                        {
                            ID = new Guid("9481d4f5-05f9-4ee6-b579-a1851c1d39f6"),
                            FirstName = "Bobby",
                            LastName = "Doggy",
                            PartyID = new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"),
                            VotingTypeId = new Guid("8254d087-4ad7-4069-816f-5ed97d119716")
                        },
                        new
                        {
                            ID = new Guid("6fd660d7-f201-49cc-8c18-170676f158ff"),
                            FirstName = "Dancila",
                            LastName = "Viorica",
                            PartyID = new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"),
                            VotingTypeId = new Guid("8254d087-4ad7-4069-816f-5ed97d119716")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
