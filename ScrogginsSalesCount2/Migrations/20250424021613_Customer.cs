using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Name" },
                values: new object[,]
                {
                    { 1, "David Troy Bryant / Mary L. Bryant" },
                    { 2, "May Bland" },
                    { 3, "Andrew Russel Stoddard" },
                    { 4, "DAA Murfreesboro" },
                    { 5, "DAA Digital" },
                    { 6, "Alice Jane Giatras" },
                    { 7, "Kenneth Huddleston" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 1, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 2, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 3, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 4, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 5, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 6, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 7, new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customer_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customer_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 20, 26, 12, 7, DateTimeKind.Local).AddTicks(133));
        }
    }
}
