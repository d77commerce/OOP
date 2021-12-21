using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismVehicles.Models
{
    internal interface IVehicle
    {
        double FuelQuantity { get; set; }
        double FuelPerKm { get; set; }
        public void Drive(double distans);
        public void Refil(double liters);
    }
}
