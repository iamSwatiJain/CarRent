using System;

namespace CarRent.Vehicles
{
    public class SmallCar : IVehicle
    {
        public Double DayFactor => 1;
        public Double DistanceFactor => 1;
        public String RegistrationNo { get; }
        public Booking Booking { get; set; }

        public SmallCar(String regNo)
        {
            RegistrationNo = regNo;
        }
    }
}
