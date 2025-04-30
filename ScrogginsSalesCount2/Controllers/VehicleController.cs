using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ScrogginsSalesCount2.Models;
using System.Linq;

namespace ScrogginsSalesCount2.Controllers
{
    public class VehicleController : Controller
    {
        private VehicleContext context { get; set; }

        public VehicleController(VehicleContext ctx)
        {
            context = ctx;
        }

       
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Sale = context.SalesPeople.OrderBy(c => c.Name).ToList();
            return View("AddEdit", new Vehicle());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Sale = context.SalesPeople.OrderBy(c => c.Name).ToList();
            var vehicle = context.Vehicles.Find(id);
            return View("AddEdit", vehicle);
        }

        [HttpPost]
        public IActionResult Save(Vehicle vehicle)
        {

            if (ModelState.IsValid)
            {
                if (vehicle.VehicleId == 0)
                {
                    context.Vehicles.Add(vehicle);
                }
                else
                {
                    context.Vehicles.Update(vehicle);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (vehicle.VehicleId == 0) ? "Add" : "Edit";
                ViewBag.Sale = context.SalesPeople.OrderBy(c => c.Name).ToList();
                return RedirectToAction("Index", "Home");
            }
        }
                                                                             
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var vehicle = context.Vehicles.Find(id);
            return View("Delete", vehicle);
        }

        [HttpPost]
        public IActionResult Delete(Vehicle vehicle)
        {
            context.Vehicles.Remove(vehicle);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
