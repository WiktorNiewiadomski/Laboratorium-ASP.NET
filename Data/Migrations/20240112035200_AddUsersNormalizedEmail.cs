using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersNormalizedEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28ae38b0-5ceb-4e4e-a57a-fe11f5b03a44", "b6fccfcb-f9ae-4a40-a725-df9e6f9323cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6424f1c8-ec84-41dd-aac4-34a81f88c490", "de4e63cc-3286-4ea2-9496-2a46e5a2319e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28ae38b0-5ceb-4e4e-a57a-fe11f5b03a44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6424f1c8-ec84-41dd-aac4-34a81f88c490");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6fccfcb-f9ae-4a40-a725-df9e6f9323cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de4e63cc-3286-4ea2-9496-2a46e5a2319e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "201193a1-454f-482c-918c-11c496051c46", "201193a1-454f-482c-918c-11c496051c46", "admin", "ADMIN" },
                    { "8ed3d664-dc24-48d7-96fb-2b76e1b8a1e7", "8ed3d664-dc24-48d7-96fb-2b76e1b8a1e7", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e94da76-8189-439e-a76d-15c196fc2ab0", 0, "f20c1b06-9479-4eb9-995c-ea3fff45765f", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAIAAYagAAAAEB8MJmcXSpp4TO5kDYNUeXwmEZ8fOnrlSfhbu0f611Yd4f2mHZdRMJgBiuPK8WBT6g==", null, false, "f7aabf14-da50-44f7-8856-9496fcacdb3c", false, "adam" },
                    { "cc7bed2a-b130-4cde-8e7b-d9dab81cae7c", 0, "8bd24329-7352-4fe6-9f6c-340c36133870", "jacek@wsei.edu.pl", true, false, null, "JACEK@WSEI.EDU.PL", "JACEK", null, null, false, "a7ceae9d-9afb-4599-b6cb-e7a344022018", false, "jacek" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "201193a1-454f-482c-918c-11c496051c46", "0e94da76-8189-439e-a76d-15c196fc2ab0" },
                    { "8ed3d664-dc24-48d7-96fb-2b76e1b8a1e7", "cc7bed2a-b130-4cde-8e7b-d9dab81cae7c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "201193a1-454f-482c-918c-11c496051c46", "0e94da76-8189-439e-a76d-15c196fc2ab0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ed3d664-dc24-48d7-96fb-2b76e1b8a1e7", "cc7bed2a-b130-4cde-8e7b-d9dab81cae7c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "201193a1-454f-482c-918c-11c496051c46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ed3d664-dc24-48d7-96fb-2b76e1b8a1e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e94da76-8189-439e-a76d-15c196fc2ab0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc7bed2a-b130-4cde-8e7b-d9dab81cae7c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28ae38b0-5ceb-4e4e-a57a-fe11f5b03a44", "28ae38b0-5ceb-4e4e-a57a-fe11f5b03a44", "admin", "ADMIN" },
                    { "6424f1c8-ec84-41dd-aac4-34a81f88c490", "6424f1c8-ec84-41dd-aac4-34a81f88c490", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b6fccfcb-f9ae-4a40-a725-df9e6f9323cb", 0, "d734da7f-c2d5-49b2-a728-832dc15ec276", "adam@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAECKDoFyDHoDG6+suCcB0yeeWYnmxBESmRvOmSu85lGNtmOJnIdCEyfRahODp7qGUCQ==", null, false, "9cae9086-c955-4b08-b74e-628c82834720", false, "adam" },
                    { "de4e63cc-3286-4ea2-9496-2a46e5a2319e", 0, "bdf316cc-77ae-4e70-a34e-8e2524b67ad1", "jacek@wsei.edu.pl", true, false, null, null, "JACEK", null, null, false, "852a71e4-affb-4289-8982-f6159fce1ec8", false, "jacek" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28ae38b0-5ceb-4e4e-a57a-fe11f5b03a44", "b6fccfcb-f9ae-4a40-a725-df9e6f9323cb" },
                    { "6424f1c8-ec84-41dd-aac4-34a81f88c490", "de4e63cc-3286-4ea2-9496-2a46e5a2319e" }
                });
        }
    }
}
