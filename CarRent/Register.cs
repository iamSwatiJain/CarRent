using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Vehicles
{
    public class Register
    {
        private IDictionary<Guid, Booking> _bookings = new Dictionary<Guid, Booking>();
        private IDictionary<String, IVehicle> _vehicles = new Dictionary<String, IVehicle>();
        private IDictionary<String, Customer> _customers = new Dictionary<String, Customer>();

        private static Register _instance;
        public static Register Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Register();
                }

                return _instance;
            }
        }

        #region Booking
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

        public Booking GetBooking(Guid id)
        {
            return _bookings.FirstOrDefault(x => x.Key == id).Value;
        }

        public IEnumerable<Booking> GetBookings()
        {
            return _bookings.Select(x => x.Value);
        }

        public IEnumerable<Booking> GetBookings(Func<KeyValuePair<Guid, Booking>, Boolean> predicate)
        {
            return _bookings.Where(predicate).Select(x => x.Value);
        }

        public void UpdateBooking(Guid id, Booking booking)
        {
            _bookings[id] = booking;
        }

        public void DeleteBooking(Guid id)
        {
            _bookings.Remove(id);
        }
        #endregion

        #region Customer
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer.SocialSecurityNumber, customer);
        }

        public Customer GetCustomer(String CustoemrId)
        {
            return _customers.FirstOrDefault(x => x.Key == CustoemrId).Value;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers.Select(x => x.Value);
        }

        public IEnumerable<Customer> GetCustomers(Func<KeyValuePair<String, Customer>, Boolean> predicate)
        {
            return _customers.Where(predicate).Select(x => x.Value);
        }

        public void UpdateCustomer(String CustomerId, Customer customer)
        {
            _customers[CustomerId] = customer;
        }

        public void DeleteCustomer(String CustomerId)
        {
            _customers.Remove(CustomerId);
        }
        #endregion

        #region Vehicle
        public void AddVehicle(IVehicle vehicle)
        {
            _vehicles.Add(vehicle.RegistrationNo, vehicle);
        }

        public IVehicle GetVehicle(String regNo)
        {
            return _vehicles.FirstOrDefault(x => x.Key == regNo).Value;
        }

        public IEnumerable<IVehicle> GetVehicles()
        {
            return _vehicles.Select(x => x.Value);
        }

        public IEnumerable<IVehicle> GetVehicles(Func<KeyValuePair<String, IVehicle>, Boolean> predicate)
        {
            return _vehicles.Where(predicate).Select(x => x.Value);
        }

        public void UpdateVehicle(String regNo, IVehicle vehicle)
        {
            _vehicles[regNo] = vehicle;
        }

        public void DeleteVehicle(String regNo)
        {
            _vehicles.Remove(regNo);
        }

        #endregion
    }
}
