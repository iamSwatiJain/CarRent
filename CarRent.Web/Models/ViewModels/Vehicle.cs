using System;

namespace CarRent.Web.Models.ViewModels
{
    public class Vehicle
    {
        public Double DayFactor { get; set; }
        public Double DistanceFactor { get; set; }
        public String RegistrationNo { get; set; }

        //added
        public Guid BookingId { get; set; }

        public String Type { get; set; }
    }
}