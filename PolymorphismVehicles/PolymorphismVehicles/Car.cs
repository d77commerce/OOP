using PolymorphismVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismVehicles
{
    public class Car : IVehicle

    { 
        
      
        public Car(double fuelQuantity, double fuelPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelPerKm = fuelPerKm;
        }

        public double FuelQuantity {get;set;}
       
        public double FuelPerKm { get; set; }
       
        public void Drive(double distans)
        {
           if(FuelQuantity-(distans * FuelPerKm * 0.9) >= 0)
            {
                FuelQuantity -= distans * FuelPerKm * 0.9;
                Console.WriteLine($"{GetType().Name} travelled {distans} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public void Refil(double liters)
        {
            FuelQuantity += liters;
           
        }
    }
}
