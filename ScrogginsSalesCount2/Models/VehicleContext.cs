using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;

namespace ScrogginsSalesCount2.Models
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { }
        public DbSet<Vehicle> Vehicles { get; set; } = null!;
        public DbSet<SalesPerson> SalesPeople { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            
            modelBuilder.Entity<Vehicle>().HasData(
                    new Vehicle
                    {
                        VehicleId = 1,
                        Stock = "506094a",
                        Year = 2015,
                        Make = "GMC",
                        Model = "Sierra 1500",
                        CustomerName = "David Troy Bryant / Mary L. Bryant",
                        SalesPersonId = 1,
                        SaleDate = "04/01/2025"
                    },
                    new Vehicle
                    {
                        VehicleId = 2,
                        Stock = "508229",
                        Year = 2022,
                        Make = "Volkswagen",
                        Model = "Atlas",
                        CustomerName = "Mary Bland",
                        SalesPersonId = 11,
                        SaleDate = "04/01/2025"
                    },
                    new Vehicle
                    {
                        VehicleId = 3,
                        Stock = "506744b",
                        Year = 2017,
                        Make = "Chevrolet",
                        Model = "Silverado",
                        CustomerName = "Andrew Russel Stoddard",
                        SalesPersonId = 3,
                        SaleDate = "04/02/2025"
                    },
                    new Vehicle
                    {
                        VehicleId = 4,
                        Stock = "505252a",
                        Year = 2013,
                        Make = "Ford",
                        Model = "Fusion",
                        CustomerName = "DAA Murfreesboro",
                        SalesPersonId = 8,
                        SaleDate = "04/02/2025"
                    },
                    new Vehicle
                    {
                        VehicleId = 5,
                        Stock = "508054",
                        Year = 2019,
                        Make = "Chevrolet",
                        Model = "Silverado 2500HD",
                        CustomerName = "DAA Digital",
                        SalesPersonId = 8,
                        SaleDate = "04/03/2025"
                    },
                    new Vehicle
                    {
                        VehicleId = 6,
                        Stock = "505725",
                        Year = 2019,
                        Make = "Ford",
                        Model = "F150",
                        CustomerName = "Alice Jane Giatras",
                        SalesPersonId = 2,
                        SaleDate = "04/03/2025"
                    },
                    new Vehicle
                    {
                        VehicleId = 7,
                        Stock = "505887",
                        Year = 2020,
                        Make = "Chevrolet",
                        Model = "Express 2500 Cutaway",
                        CustomerName = "Kenneth Huddleston",
                        SalesPersonId = 11,
                        SaleDate = "04/03/2025"
                    }


                );
            modelBuilder.Entity<SalesPerson>().HasData(
                    new SalesPerson
                    {
                        SalesPersonId = 1,
                        Name = "Bowen, C"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 2,
                        Name = "Williamson, B"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 3,
                        Name = "Morris, R"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 4,
                        Name = "Davis, C"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 5,
                        Name = "Wilfong, T"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 6,
                        Name = "Howse, J"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 7,
                        Name = "Sartain, G"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 8,
                        Name = "WHOLESALE"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 9,
                        Name = "DiMartino, M"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 10,
                        Name = "Lopez, E"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 11,
                        Name = "Bland, L"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 12,
                        Name = "Salgado, D"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 13,
                        Name = "Murf House"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 14,
                        Name = "Mills, B"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 15,
                        Name = "Howell, P"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 16,
                        Name = "Palmer, N (memphis)"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 18,
                        Name = "Coleman, D (memphis)"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 19,
                        Name = "Firika, D (memphis)"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 20,
                        Name = "Paez, J (memphis)"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 21,
                        Name = "Varela, E (memphis)"
                    },
                    new SalesPerson
                    {
                        SalesPersonId = 22,
                        Name = "*need Bill of Sale*"
                    }

                );
            
        }
    }
}
