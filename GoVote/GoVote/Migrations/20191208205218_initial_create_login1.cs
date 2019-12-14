using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations
{
    public partial class initial_create_login1 : Migration
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
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex" },
                values: new object[] { new Guid("f8c6a385-03f5-4d72-9f85-809115987e95"), "Cat address", "1234567891234", "Cat City", "Cat county", "Cat Firstname", "MEOWt Lastname", "Female" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
