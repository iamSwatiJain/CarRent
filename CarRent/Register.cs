using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Vehicles
{
    public class Register
    {
        private IDictionary<Guid, Booking> _bookings = new Dictionary<Guid, Booking>();
        private IDictionary<String, IVehicle> _vehicles = new Dictionary<String, IVehicle>();

        public Booking NewBooking<TVehicle>(Customer customer) where TVehicle : IVehicle
        {
            var vehicle = _vehicles.FirstOrDefault(x => x.Value is TVehicle && x.Value.Booking == null).Value;

            if (vehicle == null)
            {
                throw new Exception($"No cars avilable of type {typeof(TVehicle).Name}");
            }

            var booking = new Booking(vehicle, customer);
            _bookings.Add(booking.Id, booking);

            return booking;
        }

        public void AddCar(IVehicle vehicle)
        {
            _vehicles.Add(vehicle.RegistrationNo, vehicle);
        }       
    }
}
