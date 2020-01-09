using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.CandidateDatabase
{
    public partial class CandidateDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PartyID = table.Column<Guid>(nullable: false),
                    VotingTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID", "VotingTypeId" },
                values: new object[] { new Guid("799eca60-bb52-4fe5-ad9d-1792f7d3e809"), "Kat", "Kitty", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"), new Guid("ae040cc6-c820-4f54-8173-0510907c04ee") });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID", "VotingTypeId" },
                values: new object[] { new Guid("9481d4f5-05f9-4ee6-b579-a1851c1d39f6"), "Bobby", "Doggy", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID", "VotingTypeId" },
                values: new object[] { new Guid("6fd660d7-f201-49cc-8c18-170676f158ff"), "Dancila", "Viorica", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
