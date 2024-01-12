using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddComponentEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraphicsCard",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "computers");

            migrationBuilder.AddColumn<int>(
                name: "GraphicsCardId",
                table: "computers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProcessorId",
                table: "computers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StorageId",
                table: "computers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "graphics_cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Memory = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_graphics_cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "processors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CoreCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CacheSize = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ComputerType", "manufacture_date", "GraphicsCardId", "Manufacturer", "Name", "ProcessorId", "StorageId" },
                values: new object[] { 2, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "SaradaManu", "Beast 3X8", 1, 1 });

            migrationBuilder.UpdateData(
                table: "computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ComputerType", "manufacture_date", "GraphicsCardId", "Manufacturer", "Name", "ProcessorId", "StorageId" },
                values: new object[] { 4, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "AlbinoPC", "Workload B30", 2, 2 });

            migrationBuilder.InsertData(
                table: "graphics_cards",
                columns: new[] { "Id", "Memory", "Name" },
                values: new object[,]
                {
                    { 1, 12, "GeForce RTX 4070" },
                    { 2, 8, "Radeon RX 6600" }
                });

            migrationBuilder.InsertData(
                table: "processors",
                columns: new[] { "Id", "CacheSize", "CoreCount", "Name" },
                values: new object[,]
                {
                    { 1, 24, 14, "Intel Core i5-13600K" },
                    { 2, 35, 6, "AMD Ryzen 5 3600" }
                });

            migrationBuilder.InsertData(
                table: "storages",
                columns: new[] { "Id", "Name", "Size", "Type" },
                values: new object[,]
                {
                    { 1, "ADATA Ultimate SU650", 1000, "SSD" },
                    { 2, "SAMSUNG 980", 500, "SSD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_computers_GraphicsCardId",
                table: "computers",
                column: "GraphicsCardId");

            migrationBuilder.CreateIndex(
                name: "IX_computers_ProcessorId",
                table: "computers",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_computers_StorageId",
                table: "computers",
                column: "StorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_computers_graphics_cards_GraphicsCardId",
                table: "computers",
                column: "GraphicsCardId",
                principalTable: "graphics_cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_computers_processors_ProcessorId",
                table: "computers",
                column: "ProcessorId",
                principalTable: "processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_computers_storages_StorageId",
                table: "computers",
                column: "StorageId",
                principalTable: "storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_computers_graphics_cards_GraphicsCardId",
                table: "computers");

            migrationBuilder.DropForeignKey(
                name: "FK_computers_processors_ProcessorId",
                table: "computers");

            migrationBuilder.DropForeignKey(
                name: "FK_computers_storages_StorageId",
                table: "computers");

            migrationBuilder.DropTable(
                name: "graphics_cards");

            migrationBuilder.DropTable(
                name: "processors");

            migrationBuilder.DropTable(
                name: "storages");

            migrationBuilder.DropIndex(
                name: "IX_computers_GraphicsCardId",
                table: "computers");

            migrationBuilder.DropIndex(
                name: "IX_computers_ProcessorId",
                table: "computers");

            migrationBuilder.DropIndex(
                name: "IX_computers_StorageId",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "GraphicsCardId",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "ProcessorId",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "StorageId",
                table: "computers");

            migrationBuilder.AddColumn<string>(
                name: "GraphicsCard",
                table: "computers",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "computers",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "computers",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ComputerType", "manufacture_date", "GraphicsCard", "Manufacturer", "Name", "Processor", "Storage" },
                values: new object[] { 1, new DateTime(2018, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "GK1", "Apple", "Nazwa 1", "Procesor 1", "512Gb" });

            migrationBuilder.UpdateData(
                table: "computers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ComputerType", "manufacture_date", "GraphicsCard", "Manufacturer", "Name", "Processor", "Storage" },
                values: new object[] { 3, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "GK2", "Samsung", "Nazwa 2", "Procesor 2", "1Tb" });
        }
    }
}
