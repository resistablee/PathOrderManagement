using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class cargocompainestableremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_CargoCompaines_CompanyID",
                table: "Cargo");

            migrationBuilder.DropTable(
                name: "CargoCompaines");

            migrationBuilder.DropIndex(
                name: "IX_Cargo_CompanyID",
                table: "Cargo");

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

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Cargo");

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "Cargo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "OrderCategory",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("a3435274-db2a-4c17-984a-fb4229f8ac72"), new DateTime(2022, 5, 13, 3, 54, 58, 711, DateTimeKind.Local).AddTicks(8785), null, false, "Gıda" },
                    { new Guid("e24b4a7d-51ba-4f62-bef2-01a59b70d9f0"), new DateTime(2022, 5, 13, 3, 54, 58, 711, DateTimeKind.Local).AddTicks(8475), null, false, "Giyim" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "Firstname", "IsDeleted", "Lastname", "Password", "Phone", "RefreshToken", "RefreshTokenExpireDate", "UserType" },
                values: new object[,]
                {
                    { new Guid("3e58279c-0821-4de0-b111-5997b72a8ba8"), new DateTime(2022, 5, 13, 3, 54, 58, 709, DateTimeKind.Local).AddTicks(8950), null, "superadmin@path.com.tr", "SuperAdmin", false, "Path", "super123", "0553 553 5353", null, null, 1 },
                    { new Guid("6986a38a-788d-46d6-b745-e5ebc259e4b8"), new DateTime(2022, 5, 13, 3, 54, 58, 710, DateTimeKind.Local).AddTicks(8783), null, "resistablee7@hotmail.com", "Selman", false, "KOYAN", "123", "0553 421 0543", null, null, 4 },
                    { new Guid("9db4f98a-c5ed-41ee-afe1-8bfe1b29b727"), new DateTime(2022, 5, 13, 3, 54, 58, 710, DateTimeKind.Local).AddTicks(8766), null, "systemadmin@path.com.tr", "SystemAdmin", false, "Path", "system123", "0507 520 4582", null, null, 2 },
                    { new Guid("f30fa3d6-3ea1-4e7a-bf6e-7d8df6ecc853"), new DateTime(2022, 5, 13, 3, 54, 58, 710, DateTimeKind.Local).AddTicks(8780), null, "admin@path.com.tr", "Admin", false, "Path", "admin123", "0542 652 2358", null, null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("a3435274-db2a-4c17-984a-fb4229f8ac72"));

            migrationBuilder.DeleteData(
                table: "OrderCategory",
                keyColumn: "Id",
                keyValue: new Guid("e24b4a7d-51ba-4f62-bef2-01a59b70d9f0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3e58279c-0821-4de0-b111-5997b72a8ba8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6986a38a-788d-46d6-b745-e5ebc259e4b8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9db4f98a-c5ed-41ee-afe1-8bfe1b29b727"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f30fa3d6-3ea1-4e7a-bf6e-7d8df6ecc853"));

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Cargo");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyID",
                table: "Cargo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CargoCompaines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoCompaines", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_CompanyID",
                table: "Cargo",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_CargoCompaines_CompanyID",
                table: "Cargo",
                column: "CompanyID",
                principalTable: "CargoCompaines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
