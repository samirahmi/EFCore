using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Day15EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldLastUpdateinStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parent",
                keyColumn: "ParentId",
                keyValue: new Guid("753a2c01-6bc9-4345-8c76-b90c3daf895f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parent",
                keyColumn: "ParentId",
                keyValue: new Guid("8ae47d71-d036-4513-afea-00820b279388"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                schema: "dbo",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parent",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("d21763a0-301f-472d-982e-c3b575d37094"), "Konoha", "Fugaku" },
                    { new Guid("f4df6a84-94eb-4b2e-996e-758ce24045a3"), "Miyagi", "Hatake" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parent",
                keyColumn: "ParentId",
                keyValue: new Guid("d21763a0-301f-472d-982e-c3b575d37094"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parent",
                keyColumn: "ParentId",
                keyValue: new Guid("f4df6a84-94eb-4b2e-996e-758ce24045a3"));

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                schema: "dbo",
                table: "Students");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parent",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("753a2c01-6bc9-4345-8c76-b90c3daf895f"), "Konoha", "Fugaku" },
                    { new Guid("8ae47d71-d036-4513-afea-00820b279388"), "Miyagi", "Hatake" }
                });
        }
    }
}
