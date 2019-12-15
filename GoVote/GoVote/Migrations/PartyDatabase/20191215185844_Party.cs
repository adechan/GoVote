using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.PartyDatabase
{
    public partial class Party : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    PartyID = table.Column<Guid>(nullable: false),
                    PartyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.PartyID);
                });

            migrationBuilder.InsertData(
                table: "Parties",
                columns: new[] { "PartyID", "PartyName" },
                values: new object[] { new Guid("8c014a9d-c44b-42da-8eeb-21edeb756842"), "Cool Cats Political Party" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}
