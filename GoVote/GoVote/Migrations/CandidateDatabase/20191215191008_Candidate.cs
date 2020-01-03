using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.CandidateDatabase
{
    public partial class Candidate : Migration
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
                    PartyID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID" },
                values: new object[] { new Guid("9e1bd44b-eb0c-4758-96f7-582ef41997fe"), "Kat", "Kitty", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
