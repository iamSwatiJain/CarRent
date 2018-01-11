using CarRent.Vehicles;
using System;

namespace CarRent
{
    public class Booking
    {
        public Guid Id { get; } = Guid.NewGuid();

        public IVehicle Vehicle { get; }
        public DateTime CheckedOutAt { get; private set; }
        public DateTime CheckedInAt { get; private set; }
        public Double DrivenDistance { get; private set; } = 0;

        public Customer Customer { get; }

        public Booking(IVehicle vehicle, Customer customer)
        {
            Vehicle = vehicle;
            Customer = customer;
        }

        public Double CalculatePrice()
        {
            double baseDayRent = 1000;
            double baseKmPrice = 10;

            return baseDayRent * ((CheckedInAt.Date - CheckedOutAt.Date).TotalDays) * Vehicle.DayFactor + baseKmPrice * DrivenDistance * Vehicle.DistanceFactor;
        }

        public void CheckIn(DateTime time, Double distanceDriven)
        {
            // add check in timestamp and distance driven to booking
            CheckedInAt = time;
            DrivenDistance = distanceDriven;
            Vehicle.Booking = null;
        }

        public void CheckOut(DateTime time)
        {
            // add check out date to the booking
            CheckedOutAt = time;
            Vehicle.Booking = this;
        }
    }
}
