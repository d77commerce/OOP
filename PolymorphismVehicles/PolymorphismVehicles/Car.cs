using PolymorphismVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismVehicles
{
    public class Car : IVehicle

    {
        private double fuelQuantity;

        public Car(double fuelQuantity, double fuelPerKm, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelPerKm = fuelPerKm;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                fuelQuantity = value;
            }
        }
        public double FuelPerKm { get; set; }
        public double TankCapacity { get; set; }

        public void Drive(double distans)
        {
            if (FuelQuantity - (distans * (FuelPerKm + 0.9)) >= 0)
            {
                FuelQuantity -= distans * (FuelPerKm + 0.9);
                Console.WriteLine($"{GetType().Name} travelled {distans} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public void Refil(double liters)
        {  
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (liters + FuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank"); 
            }     
            else
            {
                FuelQuantity += liters;
            }
        }
    }
}
