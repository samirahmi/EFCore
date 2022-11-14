using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Day15EFCore.Migrations
{
    /// <inheritdoc />
    public partial class GuidParentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parent",
                schema: "dbo",
                columns: table => new
                {
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ParentName = table.Column<string>(type: "VarChar(200)", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.ParentId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parent",
                schema: "dbo");
        }
    }
}
