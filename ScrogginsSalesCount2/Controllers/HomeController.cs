using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScrogginsSalesCount2.Models;

namespace ScrogginsSalesCount2.Controllers
{
    public class HomeController : Controller
    {
        private VehicleContext context {  get; set; }

        public HomeController(VehicleContext ctx) => context = ctx;
        
        
        public IActionResult Index()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .OrderBy(v => v.SaleDate).ToList();
            return View(query);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Jan()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0,2) == "01")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index",query);
        }
        public IActionResult Feb()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "02")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Mar()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "03")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Apr()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "04")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }

        //The following methods are for the rest of the year. Just preparing for the future :)
        public IActionResult May()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "05")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Jun()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "06")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Jul()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "07")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Aug()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "08")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Sep()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "09")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Oct()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "10")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Nov()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "11")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }
        public IActionResult Dec()
        {
            var query = context.Vehicles
                .Include(v => v.SalesPerson)
                .Where(v => v.SaleDate.Substring(0, 2) == "12")
                .OrderBy(v => v.SaleDate).ToList();
            return View("Index", query);
        }


        
    }
}
