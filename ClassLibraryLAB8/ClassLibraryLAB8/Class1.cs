using System;
using System.Collections.Generic;

// Бібліотека класів
namespace VehicleLibrary
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public double Mileage { get; set; }
        public int Power { get; set; }
        public int Cylinders { get; set; }

        public Vehicle() { }

        public Vehicle(string brand, double mileage, int power, int cylinders)
        {
            Brand = brand;
            Mileage = mileage;
            Power = power;
            Cylinders = cylinders;
        }

        public Vehicle(Vehicle other)
        {
            Brand = other.Brand;
            Mileage = other.Mileage;
            Power = other.Power;
            Cylinders = other.Cylinders;
        }

        public virtual void ChangePower(int newPower)
        {
            Power = newPower;
        }

        public virtual void ChangeMileage(double newMileage)
        {
            Mileage = newMileage;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Пробіг: {Mileage}, Потужність: {Power}, Кількість циліндрів: {Cylinders}");
        }
    }

    public class Lorry : Vehicle
    {
        public double LoadCapacity { get; set; }

        public Lorry() : base() { }

        public Lorry(string brand, double mileage, int power, int cylinders, double loadCapacity) : base(brand, mileage, power, cylinders)
        {
            LoadCapacity = loadCapacity;
        }

        public Lorry(Lorry other) : base(other)
        {
            LoadCapacity = other.LoadCapacity;
        }

        public void ChangeLoadCapacity(double newCapacity)
        {
            LoadCapacity = newCapacity;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Вантажопідйомність: {LoadCapacity}");
        }
    }

    public class Car : Vehicle
    {
        public int PassengerCount { get; set; }

        public Car() : base() { }

        public Car(string brand, double mileage, int power, int cylinders, int passengerCount) : base(brand, mileage, power, cylinders)
        {
            PassengerCount = passengerCount;
        }

        public Car(Car other) : base(other)
        {
            PassengerCount = other.PassengerCount;
        }

        public void ChangePassengerCount(int newCount)
        {
            PassengerCount = newCount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість пасажирів: {PassengerCount}");
        }
    }
}