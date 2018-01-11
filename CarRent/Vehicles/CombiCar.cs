using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Vehicles
{
    class CombiCar : IVehicle
    {
        public Double DayFactor => 1.3;
        public Double DistanceFactor => 1;
        public String RegistrationNo { get; }
        public Booking Booking { get; set; }

        public CombiCar(String regNo)
        {
            RegistrationNo = regNo;
        }
    }
}
