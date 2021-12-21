using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismVehicles.Models
{
    public interface IVehicle
    {
        double FuelQuantity { get; set; }
        double FuelPerKm { get; set; }
        double TankCapacity { get; set; }   
        public void Drive(double distans);
        public void Refil(double liters);
    }
}
