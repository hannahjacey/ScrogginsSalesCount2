using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class SalesPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customer_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "SalesPersonId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.CreateTable(
                name: "SalesPeople",
                columns: table => new
                {
                    SalesPersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPeople", x => x.SalesPersonId);
                });

            migrationBuilder.InsertData(
                table: "SalesPeople",
                columns: new[] { "SalesPersonId", "Name" },
                values: new object[,]
                {
                    { 1, "Bowen, C" },
                    { 2, "Williamson, B" },
                    { 3, "Morris, R" },
                    { 4, "Davis, C" },
                    { 5, "Wilfong, T" },
                    { 6, "Howse, J" },
                    { 7, "Sartain, G" },
                    { 8, "WHOLESALE" },
                    { 9, "DiMartino, M" },
                    { 10, "Lopez, E" },
                    { 11, "Bland, L" },
                    { 12, "Salgado, D" },
                    { 13, "Murf House" },
                    { 14, "Mills, B" },
                    { 15, "Howell, P" },
                    { 16, "Palmer, N (memphis)" },
                    { 18, "Coleman, D (memphis)" },
                    { 19, "Firika, D (memphis)" },
                    { 20, "Paez, J (memphis)" },
                    { 21, "Varela, E (memphis)" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(8921), 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9132), 11 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9136), 3 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9143), 8 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9146), 8 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9150), 2 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "SaleDate", "SalesPersonId" },
                values: new object[] { new DateTime(2025, 4, 24, 10, 54, 46, 688, DateTimeKind.Local).AddTicks(9162), 11 });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SalesPersonId",
                table: "Vehicles",
                column: "SalesPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_SalesPeople_SalesPersonId",
                table: "Vehicles",
                column: "SalesPersonId",
                principalTable: "SalesPeople",
                principalColumn: "SalesPersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_SalesPeople_SalesPersonId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "SalesPeople");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_SalesPersonId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SalesPersonId",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                column: "SaleDate",
                value: new DateTime(2025, 4, 23, 21, 16, 13, 31, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customer_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
