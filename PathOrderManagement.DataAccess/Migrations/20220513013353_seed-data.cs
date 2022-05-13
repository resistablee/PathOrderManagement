using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("9054e8d2-8af6-431c-aaad-f83abc441075"));

            migrationBuilder.DeleteData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("f7866ba0-eaa6-409a-b3a3-50395ea3453e"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("1b286cd9-1d18-42ef-8728-b1aa3f2944ec"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("7a73c9dc-1c20-480f-8e1c-19e2270b437f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3abfb7ed-fe45-4984-9d10-b763447ea129"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a7545edb-a67a-4dde-9299-4a56d4baba92"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cb21fad8-3d21-4251-8964-0fac3956322d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e04492db-87c8-4a43-9388-965f57362b11"));

            migrationBuilder.InsertData(
                table: "CargoCompanies",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"), new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(3635), "Yurtiçi Kargo" },
                    { new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"), new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(3946), "Aras Kargo" }
                });

            migrationBuilder.InsertData(
                table: "OrderCategory",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"), new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(1845), null, false, "Gıda" },
                    { new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"), new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(1478), null, false, "Giyim" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("b08851a1-7117-46bd-8736-4e271fd80bda"), new DateTime(2022, 5, 13, 4, 33, 52, 241, DateTimeKind.Local).AddTicks(2123), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 },
                    { new Guid("b792f048-94f4-4e34-850f-5dfe092ae196"), new DateTime(2022, 5, 13, 4, 33, 52, 241, DateTimeKind.Local).AddTicks(2140), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 },
                    { new Guid("c4851dd8-c1b4-45a4-a3ef-2c6e97fe924b"), new DateTime(2022, 5, 13, 4, 33, 52, 241, DateTimeKind.Local).AddTicks(2142), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 },
                    { new Guid("d417f97a-9613-44ba-a392-3df4af9a3302"), new DateTime(2022, 5, 13, 4, 33, 52, 240, DateTimeKind.Local).AddTicks(1944), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"));

            migrationBuilder.DeleteData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b08851a1-7117-46bd-8736-4e271fd80bda"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b792f048-94f4-4e34-850f-5dfe092ae196"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c4851dd8-c1b4-45a4-a3ef-2c6e97fe924b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d417f97a-9613-44ba-a392-3df4af9a3302"));

            migrationBuilder.InsertData(
                table: "CargoCompanies",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("9054e8d2-8af6-431c-aaad-f83abc441075"), new DateTime(2022, 5, 13, 4, 28, 20, 11, DateTimeKind.Local).AddTicks(2114), "Yurtiçi Kargo" },
                    { new Guid("f7866ba0-eaa6-409a-b3a3-50395ea3453e"), new DateTime(2022, 5, 13, 4, 28, 20, 11, DateTimeKind.Local).AddTicks(2424), "Aras Kargo" }
                });

            migrationBuilder.InsertData(
                table: "OrderCategory",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("1b286cd9-1d18-42ef-8728-b1aa3f2944ec"), new DateTime(2022, 5, 13, 4, 28, 20, 11, DateTimeKind.Local).AddTicks(317), null, false, "Gıda" },
                    { new Guid("7a73c9dc-1c20-480f-8e1c-19e2270b437f"), new DateTime(2022, 5, 13, 4, 28, 20, 10, DateTimeKind.Local).AddTicks(9987), null, false, "Giyim" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("3abfb7ed-fe45-4984-9d10-b763447ea129"), new DateTime(2022, 5, 13, 4, 28, 20, 9, DateTimeKind.Local).AddTicks(887), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 },
                    { new Guid("a7545edb-a67a-4dde-9299-4a56d4baba92"), new DateTime(2022, 5, 13, 4, 28, 20, 10, DateTimeKind.Local).AddTicks(552), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 },
                    { new Guid("cb21fad8-3d21-4251-8964-0fac3956322d"), new DateTime(2022, 5, 13, 4, 28, 20, 10, DateTimeKind.Local).AddTicks(550), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 },
                    { new Guid("e04492db-87c8-4a43-9388-965f57362b11"), new DateTime(2022, 5, 13, 4, 28, 20, 10, DateTimeKind.Local).AddTicks(533), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 }
                });
        }
    }
}
