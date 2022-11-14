using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Day15EFCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenderToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                schema: "dbo",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "Now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parent",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("a711dfb5-2be3-40e4-9718-6fcf03d8b254"), "Miyagi", "Hatake" },
                    { new Guid("f73eb336-0b54-4a46-89dd-d8bbeaed4960"), "Konoha", "Fugaku" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parent",
                keyColumn: "ParentId",
                keyValue: new Guid("a711dfb5-2be3-40e4-9718-6fcf03d8b254"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parent",
                keyColumn: "ParentId",
                keyValue: new Guid("f73eb336-0b54-4a46-89dd-d8bbeaed4960"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                schema: "dbo",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "Now()");

            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
