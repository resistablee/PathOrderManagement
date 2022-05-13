using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class categorycargoseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 35, 11, 874, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 35, 11, 874, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.InsertData(
                table: "CategoryCargo",
                columns: new[] { "Id", "CategoryID", "CompanyID", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("5b75c0e5-a79e-42e0-8503-a06cd7340180"), new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"), new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"), new DateTime(2022, 5, 13, 4, 35, 11, 874, DateTimeKind.Local).AddTicks(5851) },
                    { new Guid("8f00d167-5bb8-4a41-9b26-a4a3bfac258f"), new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"), new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"), new DateTime(2022, 5, 13, 4, 35, 11, 874, DateTimeKind.Local).AddTicks(6689) }
                });

            migrationBuilder.UpdateData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 35, 11, 874, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 35, 11, 874, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("15445a85-73ec-47e0-8b8a-6e575fc932a6"), new DateTime(2022, 5, 13, 4, 35, 11, 873, DateTimeKind.Local).AddTicks(245), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 },
                    { new Guid("1e4470dc-0374-4019-bb23-ffa086e85baa"), new DateTime(2022, 5, 13, 4, 35, 11, 871, DateTimeKind.Local).AddTicks(8910), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 },
                    { new Guid("d34eabeb-20f8-4829-8846-36088cd8e7a1"), new DateTime(2022, 5, 13, 4, 35, 11, 873, DateTimeKind.Local).AddTicks(263), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 },
                    { new Guid("e2b9854b-32e9-41a5-8da8-12edd10da5cb"), new DateTime(2022, 5, 13, 4, 35, 11, 873, DateTimeKind.Local).AddTicks(265), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryCargo",
                keyColumn: "Id",
                keyValue: new Guid("5b75c0e5-a79e-42e0-8503-a06cd7340180"));

            migrationBuilder.DeleteData(
                table: "CategoryCargo",
                keyColumn: "Id",
                keyValue: new Guid("8f00d167-5bb8-4a41-9b26-a4a3bfac258f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("15445a85-73ec-47e0-8b8a-6e575fc932a6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1e4470dc-0374-4019-bb23-ffa086e85baa"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d34eabeb-20f8-4829-8846-36088cd8e7a1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e2b9854b-32e9-41a5-8da8-12edd10da5cb"));

            migrationBuilder.UpdateData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 4, 33, 52, 242, DateTimeKind.Local).AddTicks(1478));

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
    }
}
