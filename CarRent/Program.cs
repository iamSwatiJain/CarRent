using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Vehicles
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Register reg = new Register();

            for (int i = 1; i <= 3; i++)
            {
                reg.AddCar(new SmallCar($"Small {i}"));
            }
            for (int i = 1; i <= 3; i++)
            {
                reg.AddCar(new CombiCar($"Combi {i}"));
            }
            for (int i = 1; i <= 3; i++)
            {
                reg.AddCar(new Truck($"Truck {i}"));
            }
            
            var booking1 = reg.NewBooking<CombiCar>(new Customer("Customer 01"));
            booking1.CheckOut(DateTime.Now);

            var booking2 = reg.NewBooking<SmallCar>(new Customer("Customer 02"));
            booking2.CheckOut(DateTime.Now);

            var booking3 = reg.NewBooking<SmallCar>(new Customer("Customer 03"));
            booking3.CheckOut(DateTime.Now);

            booking1.CheckIn(DateTime.Now.AddDays(3), 200.0);

            var booking4 = reg.NewBooking<SmallCar>(new Customer("Customer 04"));
            booking4.CheckOut(DateTime.Now);

            Console.WriteLine($"Bill {booking1.Customer.SocialSecurityNumber} ${booking1.CalculatePrice()}");

            Console.ReadKey();
        }
    }
}
