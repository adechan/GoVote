using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.LoginTokenDatabase
{
    public partial class LoginToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginTokens",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ExpiresAfter = table.Column<TimeSpan>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CitizenID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginTokens", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "LoginTokens",
                columns: new[] { "ID", "CitizenID", "CreationDate", "ExpiresAfter" },
                values: new object[] { new Guid("68e0883b-cbd7-4338-b0d6-b513a57cf53b"), new Guid("79923d83-a092-443b-8120-6e8466925abc"), new DateTime(2020, 1, 6, 16, 31, 36, 676, DateTimeKind.Local).AddTicks(8641), new TimeSpan(0, 1, 0, 0, 0) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginTokens");
        }
    }
}
