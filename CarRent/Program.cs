using CarRent.Entities;
using CarRent.Services;
using System;
using System.Globalization;

namespace CarRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string car = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(car));

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(priceHour, priceDay);
           rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}