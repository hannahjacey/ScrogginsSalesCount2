using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCustomerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Vehicles");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "David Troy Bryant / Mary L. Bryant", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "Mary Bland", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "Andrew Russel Stoddard", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "DAA Murfreesboro", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "DAA Digital", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "Alice Jane Giatras", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "CustomerName", "SaleDate" },
                values: new object[] { "Kenneth Huddleston", new DateTime(2025, 4, 24, 20, 48, 13, 36, DateTimeKind.Local).AddTicks(9188) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
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
                values: new object[] { 1, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 2, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 3, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 4, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 5, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 6, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "SaleDate" },
                values: new object[] { 7, new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
