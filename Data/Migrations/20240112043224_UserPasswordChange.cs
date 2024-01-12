using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UserPasswordChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "a420d729-5e78-4870-9896-5a6c11174794", "a420d729-5e78-4870-9896-5a6c11174794", "admin", "ADMIN" },
                    { "d9c1ca9d-17ee-416e-b426-a11b7f47b371", "d9c1ca9d-17ee-416e-b426-a11b7f47b371", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a599824-cf4d-442d-b8ea-a298ec567775", 0, "3fe3d2fd-8922-4080-aac5-36e89e79348f", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAIAAYagAAAAEHzGVZ3pXYaann/qZE4xU7WevwZcudkGc6qKsC6W76/5rW5WV8wwxe3iyVoFbMvI4Q==", null, false, "", false, "adam" },
                    { "42353827-ad34-4094-93ea-c4e442fc96a9", 0, "89b699f9-5b9e-4e00-bbfe-b4aac3abd353", "jacek@wsei.edu.pl", true, false, null, "JACEK@WSEI.EDU.PL", "JACEK", "AQAAAAIAAYagAAAAEFTec/RhI7oxkzUD5tf6wRCk5rmrEviJaS8heSECRrYlliU+FYBQFKydWz/Vw/CGIQ==", null, false, "", false, "jacek" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a420d729-5e78-4870-9896-5a6c11174794", "0a599824-cf4d-442d-b8ea-a298ec567775" },
                    { "d9c1ca9d-17ee-416e-b426-a11b7f47b371", "42353827-ad34-4094-93ea-c4e442fc96a9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a420d729-5e78-4870-9896-5a6c11174794", "0a599824-cf4d-442d-b8ea-a298ec567775" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d9c1ca9d-17ee-416e-b426-a11b7f47b371", "42353827-ad34-4094-93ea-c4e442fc96a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a420d729-5e78-4870-9896-5a6c11174794");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9c1ca9d-17ee-416e-b426-a11b7f47b371");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a599824-cf4d-442d-b8ea-a298ec567775");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42353827-ad34-4094-93ea-c4e442fc96a9");

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
    }
}
