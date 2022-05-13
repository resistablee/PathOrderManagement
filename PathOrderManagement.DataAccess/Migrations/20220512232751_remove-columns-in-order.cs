using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class removecolumnsinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoCompaines",
                keyColumn: "Id",
                keyValue: new Guid("15a46459-5a46-4e34-b67d-3833ff425f52"));

            migrationBuilder.DeleteData(
                table: "CargoCompaines",
                keyColumn: "Id",
                keyValue: new Guid("7c610047-3380-427d-88b7-f2ef397172e1"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("0cc7ac04-2502-4e52-87a6-5068b3b31b10"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("615bb4c8-29bf-496f-8453-5a0575fa33c6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("028dd947-1d6c-4356-b3f1-644ac8c865f6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7f505752-e71c-418c-a265-38defec99232"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("913465b4-13c8-479a-9012-4dd175003162"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f96ddac9-8007-457f-af7f-d2fb0e61465f"));

            migrationBuilder.DropColumn(
                name: "CancellationToken",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CancellationTokenIsUsed",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Order");

            migrationBuilder.InsertData(
                table: "CargoCompaines",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("46e200ec-76e7-4942-8c2c-e3152f912b40"), new DateTime(2022, 5, 13, 2, 27, 50, 779, DateTimeKind.Local).AddTicks(3338), null, false, "Aras Kargo" },
                    { new Guid("ec306c94-b075-4ae9-bab4-3e26fcbbf360"), new DateTime(2022, 5, 13, 2, 27, 50, 779, DateTimeKind.Local).AddTicks(3022), null, false, "Yurtiçi Kargo" }
                });

            migrationBuilder.InsertData(
                table: "OrderCategory",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("75d16873-2263-4721-a2d0-04367ebc91ea"), new DateTime(2022, 5, 13, 2, 27, 50, 779, DateTimeKind.Local).AddTicks(5393), null, false, "Gıda" },
                    { new Guid("929486d9-89e4-448d-93b6-96aa0a6836d8"), new DateTime(2022, 5, 13, 2, 27, 50, 779, DateTimeKind.Local).AddTicks(5092), null, false, "Giyim" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("5c84a26c-75a9-41d5-97be-7cf8d9806ae4"), new DateTime(2022, 5, 13, 2, 27, 50, 777, DateTimeKind.Local).AddTicks(4094), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 },
                    { new Guid("acee72bc-60f3-47bd-9ade-15d49b1ab7bf"), new DateTime(2022, 5, 13, 2, 27, 50, 778, DateTimeKind.Local).AddTicks(4114), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 },
                    { new Guid("c7edb877-b904-40d9-8445-7a2c38d0e31d"), new DateTime(2022, 5, 13, 2, 27, 50, 778, DateTimeKind.Local).AddTicks(4131), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 },
                    { new Guid("e2874982-4d70-4374-ac35-48676ca83eba"), new DateTime(2022, 5, 13, 2, 27, 50, 778, DateTimeKind.Local).AddTicks(4129), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoCompaines",
                keyColumn: "Id",
                keyValue: new Guid("46e200ec-76e7-4942-8c2c-e3152f912b40"));

            migrationBuilder.DeleteData(
                table: "CargoCompaines",
                keyColumn: "Id",
                keyValue: new Guid("ec306c94-b075-4ae9-bab4-3e26fcbbf360"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("75d16873-2263-4721-a2d0-04367ebc91ea"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("929486d9-89e4-448d-93b6-96aa0a6836d8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5c84a26c-75a9-41d5-97be-7cf8d9806ae4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("acee72bc-60f3-47bd-9ade-15d49b1ab7bf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7edb877-b904-40d9-8445-7a2c38d0e31d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e2874982-4d70-4374-ac35-48676ca83eba"));

            migrationBuilder.AddColumn<string>(
                name: "CancellationToken",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CancellationTokenIsUsed",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CargoCompaines",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("15a46459-5a46-4e34-b67d-3833ff425f52"), new DateTime(2022, 5, 13, 0, 49, 43, 807, DateTimeKind.Local).AddTicks(1549), null, false, "Yurtiçi Kargo" },
                    { new Guid("7c610047-3380-427d-88b7-f2ef397172e1"), new DateTime(2022, 5, 13, 0, 49, 43, 807, DateTimeKind.Local).AddTicks(1864), null, false, "Aras Kargo" }
                });

            migrationBuilder.InsertData(
                table: "OrderCategory",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0cc7ac04-2502-4e52-87a6-5068b3b31b10"), new DateTime(2022, 5, 13, 0, 49, 43, 807, DateTimeKind.Local).AddTicks(3952), null, false, "Gıda" },
                    { new Guid("615bb4c8-29bf-496f-8453-5a0575fa33c6"), new DateTime(2022, 5, 13, 0, 49, 43, 807, DateTimeKind.Local).AddTicks(3656), null, false, "Giyim" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("028dd947-1d6c-4356-b3f1-644ac8c865f6"), new DateTime(2022, 5, 13, 0, 49, 43, 806, DateTimeKind.Local).AddTicks(2711), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 },
                    { new Guid("7f505752-e71c-418c-a265-38defec99232"), new DateTime(2022, 5, 13, 0, 49, 43, 806, DateTimeKind.Local).AddTicks(2696), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 },
                    { new Guid("913465b4-13c8-479a-9012-4dd175003162"), new DateTime(2022, 5, 13, 0, 49, 43, 806, DateTimeKind.Local).AddTicks(2713), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 },
                    { new Guid("f96ddac9-8007-457f-af7f-d2fb0e61465f"), new DateTime(2022, 5, 13, 0, 49, 43, 804, DateTimeKind.Local).AddTicks(4349), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 }
                });
        }
    }
}
