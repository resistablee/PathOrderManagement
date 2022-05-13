using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathOrderManagement.DataAccess.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoCompaines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoCompaines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CancellationToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancellationTokenIsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "OrderCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_CargoCompaines_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CargoCompaines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cargo_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_CompanyID",
                table: "Cargo",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_OrderID",
                table: "Cargo",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CategoryID",
                table: "Order",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "CargoCompaines");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderCategory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
