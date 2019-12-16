using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.CandidateDatabase
{
    public partial class CandidateDatabase_seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "ID",
                keyValue: new Guid("9e1bd44b-eb0c-4758-96f7-582ef41997fe"));

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID" },
                values: new object[] { new Guid("df1a0979-f3d5-475a-b67a-529b30d481bc"), "Kat", "Kitty", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842") });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID" },
                values: new object[] { new Guid("3a727820-76a9-4ae6-a465-260ea87a56a0"), "Bobby", "Doggy", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "ID",
                keyValue: new Guid("3a727820-76a9-4ae6-a465-260ea87a56a0"));

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "ID",
                keyValue: new Guid("df1a0979-f3d5-475a-b67a-529b30d481bc"));

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID" },
                values: new object[] { new Guid("9e1bd44b-eb0c-4758-96f7-582ef41997fe"), "Kat", "Kitty", new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842") });
        }
    }
}
