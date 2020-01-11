using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.VotingTypeDatabase
{
    public partial class VotingTypeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VotingTypes",
                columns: table => new
                {
                    VotingTypeID = table.Column<Guid>(nullable: false),
                    VotingTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotingTypes", x => x.VotingTypeID);
                });

            migrationBuilder.InsertData(
                table: "VotingTypes",
                columns: new[] { "VotingTypeID", "VotingTypeName" },
                values: new object[] { new Guid("8254d087-4ad7-4069-816f-5ed97d119716"), "Alegeri prezidentiale" });

            migrationBuilder.InsertData(
                table: "VotingTypes",
                columns: new[] { "VotingTypeID", "VotingTypeName" },
                values: new object[] { new Guid("ae040cc6-c820-4f54-8173-0510907c04ee"), "Alegeri parlamentare" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VotingTypes");
        }
    }
}
