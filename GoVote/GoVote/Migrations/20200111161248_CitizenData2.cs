using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations
{
    public partial class CitizenData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "ID",
                keyValue: new Guid("5430c9fc-122f-419b-94f8-d3089675855c"));

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "ID",
                keyValue: new Guid("fb8bb7b7-30ff-47b0-887f-f36a6ac298fa"));

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex", "VotedFor" },
                values: new object[] { new Guid("c6cc8afe-3fb7-49e3-8726-a479ed2f9628"), "Prelungirea Salciei nr 11", "6000611068050", "Bacau", "Bacau", "Andreea", "Rindasu", "Female", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex", "VotedFor" },
                values: new object[] { new Guid("75a2b1a9-2a84-492a-9d88-609754d51829"), "Trandafirilor nr 19", "2940306114529", "Iasi", "Iasi", "Andreea", "Arsene", "Female", new Guid("00000000-0000-0000-0000-000000000000") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "ID",
                keyValue: new Guid("75a2b1a9-2a84-492a-9d88-609754d51829"));

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "ID",
                keyValue: new Guid("c6cc8afe-3fb7-49e3-8726-a479ed2f9628"));

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex", "VotedFor" },
                values: new object[] { new Guid("fb8bb7b7-30ff-47b0-887f-f36a6ac298fa"), "Prelungirea Salciei nr 11", "6000611068050", "Bacau", "Bacau", "Andreea", "Rindasu", "Female", new Guid("3a727820-76a9-4ae6-a465-260ea87a56a0") });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex", "VotedFor" },
                values: new object[] { new Guid("5430c9fc-122f-419b-94f8-d3089675855c"), "Trandafirilor nr 19", "2940306114529", "Iasi", "Iasi", "Andreea", "Arsene", "Female", new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
