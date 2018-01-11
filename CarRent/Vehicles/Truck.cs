using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Vehicles
{
    class Truck : IVehicle
    {
        public Double DayFactor => 1.5;
        public Double DistanceFactor => 1.5;
        public String RegistrationNo { get; }
        public Booking Booking { get; set; }

        public Truck(String regNo)
        {
            RegistrationNo = regNo;
        }
    }
}
