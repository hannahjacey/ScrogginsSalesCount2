using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSaleDateType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleDate",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "SaleDate",
                table: "Vehicles",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                column: "SaleDate",
                value: new DateOnly(1, 1, 1));
        }
    }
}
