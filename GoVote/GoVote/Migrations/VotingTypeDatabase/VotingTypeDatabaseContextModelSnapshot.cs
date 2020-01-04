﻿// <auto-generated />
using System;
using GoVote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoVote.Migrations.VotingTypeDatabase
{
    [DbContext(typeof(VotingTypeDatabaseContext))]
    partial class VotingTypeDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoVote.Data.VotingType", b =>
                {
                    b.Property<Guid>("VotingTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandidateID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VotingTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VotingTypeID");

                    b.ToTable("VotingTypes");

                    b.HasData(
                        new
                        {
                            VotingTypeID = new Guid("e3bac7ed-49ba-4ab1-ba48-8720e7b456ad"),
                            CandidateID = new Guid("9e1bd44b-eb0c-4758-96f7-582ef41997fe"),
                            VotingTypeName = "Alegeri prezidentiale"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}