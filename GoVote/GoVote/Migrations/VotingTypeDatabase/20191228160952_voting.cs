using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.VotingTypeDatabase
{
    public partial class voting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VotingTypes",
                columns: table => new
                {
                    VotingTypeID = table.Column<Guid>(nullable: false),
                    CandidateID = table.Column<Guid>(nullable: false),
                    VotingTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotingTypes", x => x.VotingTypeID);
                });

            migrationBuilder.InsertData(
                table: "VotingTypes",
                columns: new[] { "VotingTypeID", "CandidateID", "VotingTypeName" },
                values: new object[] { new Guid("e3bac7ed-49ba-4ab1-ba48-8720e7b456ad"), new Guid("9e1bd44b-eb0c-4758-96f7-582ef41997fe"), "Alegeri prezidentiale" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VotingTypes");
        }
    }
}
