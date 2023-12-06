using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    Processor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Storage = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    GraphicsCard = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    manufacture_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_computers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "computers",
                columns: new[] { "Id", "manufacture_date", "GraphicsCard", "Manufacturer", "Name", "Priority", "Processor", "Storage" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "GK1", "Apple", "Nazwa 1", 3, "Procesor 1", "512Gb" },
                    { 2, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "GK2", "Samsung", "Nazwa 2", 2, "Procesor 2", "1Tb" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "computers");
        }
    }
}
