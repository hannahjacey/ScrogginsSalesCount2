using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCustomerIdForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 414, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 415, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 415, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 415, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 415, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 415, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 50, 48, 415, DateTimeKind.Local).AddTicks(21));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2025, 4, 24, 20, 48, 35, 533, DateTimeKind.Local).AddTicks(3708));
        }
    }
}
