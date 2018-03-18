using System;

namespace CarRent.Web.Models.ViewModels
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }
        public DateTime CheckoutAt { get; set; }
        public DateTime CheckedInAt { get; set; }
    }
}