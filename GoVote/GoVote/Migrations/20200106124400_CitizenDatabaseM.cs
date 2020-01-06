using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations
{
    public partial class CitizenDatabaseM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CNP = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    County = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    VotedFor = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex", "VotedFor" },
                values: new object[] { new Guid("79923d83-a092-443b-8120-6e8466925abc"), "Prelungirea Salciei nr 11", "6000611068050", "Bacau", "Bacau", "Andreea", "Rindasu", "Female", new Guid("3a727820-76a9-4ae6-a465-260ea87a56a0") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
