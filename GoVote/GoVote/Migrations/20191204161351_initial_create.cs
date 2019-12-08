using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "ID",
                keyValue: new Guid("adc6cf08-e0ad-4829-8fa9-a4495a00077c"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex" },
                values: new object[] { new Guid("adc6cf08-e0ad-4829-8fa9-a4495a00077c"), "Cat address", "1234567891234", "Cat City", "Cat county", "Cat Firstname", "Cat Lastname", "Female" });
        }
    }
}
