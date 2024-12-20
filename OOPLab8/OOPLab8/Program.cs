using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    using VehicleLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Lorry("Volvo", 200000, 400, 6, 15000),
                new Car("Toyota", 50000, 150, 4, 5)
            };

            Console.WriteLine("Інформація про транспортні засоби:");
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
                Console.WriteLine();
            }

            Vehicle car1 = new Car("Honda", 30000, 120, 4, 4);
            Vehicle lorry1 = new Lorry("Scania", 250000, 450, 6, 20000);

            Console.WriteLine("Оновлення інформації...");
            car1.ChangeMileage(35000);
            lorry1.ChangePower(480);

            Console.WriteLine("Оновлена інформація про транспортні засоби:");
            car1.ShowInfo();
            Console.WriteLine();
            lorry1.ShowInfo();
        }
    }
}