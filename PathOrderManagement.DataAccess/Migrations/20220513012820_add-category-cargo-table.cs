using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class addcategorycargotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CargoCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCargo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryCargo_CargoCompanies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CargoCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryCargo_OrderCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "OrderCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_CompanyID",
                table: "Cargo",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCargo_CategoryID",
                table: "CategoryCargo",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCargo_CompanyID",
                table: "CategoryCargo",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_CargoCompanies_CompanyID",
                table: "Cargo",
                column: "CompanyID",
                principalTable: "CargoCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_CargoCompanies_CompanyID",
                table: "Cargo");

            migrationBuilder.DropTable(
                name: "CategoryCargo");

            migrationBuilder.DropTable(
                name: "CargoCompanies");

            migrationBuilder.DropIndex(
                name: "IX_Cargo_CompanyID",
                table: "Cargo");

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
    }
}
