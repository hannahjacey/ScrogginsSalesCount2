using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class updatesaledate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalesPeople",
                columns: new[] { "SalesPersonId", "Name" },
                values: new object[] { 22, "*need Bill of Sale*" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesPeople",
                keyColumn: "SalesPersonId",
                keyValue: 22);
        }
    }
}
