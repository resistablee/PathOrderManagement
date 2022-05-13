using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class softdeleteentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CategoryCargo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CategoryCargo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "CargoCompanies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CargoCompanies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "CargoCompanies",
                keyColumn: "Id",
                keyValue: new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.InsertData(
                table: "CategoryCargo",
                columns: new[] { "Id", "CategoryID", "CompanyID", "CreatedOn", "DeletedOn", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("28f159ff-fc7a-4af2-80ef-56b19fa211f5"), new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"), new Guid("09e6edd0-b037-47a4-abb3-97af0d33c7a1"), new DateTime(2022, 5, 13, 5, 7, 47, 153, DateTimeKind.Local).AddTicks(2895), null, false },
                    { new Guid("bd42084f-e3fd-490c-ac64-d7636f24e513"), new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"), new Guid("b24ae964-4c2a-488f-944a-f9c7c2433273"), new DateTime(2022, 5, 13, 5, 7, 47, 153, DateTimeKind.Local).AddTicks(2228), null, false }
                });

            migrationBuilder.UpdateData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("b3817af4-5107-4c39-99f9-37595c7bda31"),
                column: "CreatedOn",
                value: new DateTime(2022, 5, 13, 5, 7, 47, 152, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("62be0e98-ffaa-484e-8a03-523035b108e1"), new DateTime(2022, 5, 13, 5, 7, 47, 151, DateTimeKind.Local).AddTicks(4443), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 },
                    { new Guid("85c32bf1-48ae-45da-b754-0fe20ae96c27"), new DateTime(2022, 5, 13, 5, 7, 47, 151, DateTimeKind.Local).AddTicks(4475), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 },
                    { new Guid("c941de0c-7068-481f-88a5-0d2d33bad26c"), new DateTime(2022, 5, 13, 5, 7, 47, 150, DateTimeKind.Local).AddTicks(2026), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 },
                    { new Guid("d0241beb-0db3-4839-a405-41f406788d82"), new DateTime(2022, 5, 13, 5, 7, 47, 151, DateTimeKind.Local).AddTicks(4477), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryCargo",
                keyColumn: "Id",
                keyValue: new Guid("28f159ff-fc7a-4af2-80ef-56b19fa211f5"));

            migrationBuilder.DeleteData(
                table: "CategoryCargo",
                keyColumn: "Id",
                keyValue: new Guid("bd42084f-e3fd-490c-ac64-d7636f24e513"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("62be0e98-ffaa-484e-8a03-523035b108e1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("85c32bf1-48ae-45da-b754-0fe20ae96c27"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c941de0c-7068-481f-88a5-0d2d33bad26c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d0241beb-0db3-4839-a405-41f406788d82"));

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CategoryCargo");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CategoryCargo");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "CargoCompanies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CargoCompanies");

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
    }
}
