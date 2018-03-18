using CarRent.Vehicles;
using CarRent.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRent.Web.Controllers
{
    public class VehicleController : Controller
    {
        private readonly Register _register;

        public VehicleController()
        {
            _register = Register.Instance;
        }

        [HttpGet]
        [Route("vehicle")]
        public ActionResult Index()
        {
            var vehicles = _register.GetVehicles().Select(v => new Vehicle
            {
                BookingId = v.Booking.Id,
                RegistrationNo = v.RegistrationNo,
                DistanceFactor = v.DistanceFactor,
                DayFactor = v.DayFactor,
                Type = v.GetType().Name
            });
            return View(vehicles);
        }

        [HttpGet]
        [Route("vehicle/{id}")]
        public ActionResult Details(string id)
        {
            var vehicle = _register.GetVehicle(id);
            return View(vehicle);
        }

        [HttpGet]
        [Route("vehicle/new")]
        public ActionResult CreateGet()
        {
            return View();
        }

        [HttpPost]
        [Route("vehicle")]
        public ActionResult CreatePost([System.Web.Http.FromBody] NewVehicle vehicle)
        {
            return Redirect(Url.Action(nameof(Index)));
        }
    }
}