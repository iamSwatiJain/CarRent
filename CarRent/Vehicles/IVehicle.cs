using System;

namespace CarRent.Vehicles
{
    public interface IVehicle
    {
        Double DayFactor { get; }
        Double DistanceFactor { get; }
        String RegistrationNo { get; }

        //added
        Booking Booking { get; set; }
    }
}
