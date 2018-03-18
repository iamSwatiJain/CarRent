using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRent.Web.Models.ViewModels
{
    public class NewBooking
    {
        public String VehicleType { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime CheckoutAt { get; set; } = DateTime.Now;
    }
}