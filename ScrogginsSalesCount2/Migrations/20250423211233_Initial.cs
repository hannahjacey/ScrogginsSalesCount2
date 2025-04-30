using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScrogginsSalesCount2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stock = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "Make", "Model", "Stock", "Year" },
                values: new object[,]
                {
                    { 1, "GMC", "Sierra 1500", "506094a", 2015 },
                    { 2, "Volkswagen", "Atlas", "508229", 2022 },
                    { 3, "Chevrolet", "Silverado", "506744b", 2017 },
                    { 4, "Ford", "Fusion", "505252a", 2013 },
                    { 5, "Chevrolet", "Silverado 2500HD", "508054", 2019 },
                    { 6, "Ford", "F150", "505725", 2019 },
                    { 7, "Chevrolet", "Express 2500 Cutaway", "505887", 2020 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
