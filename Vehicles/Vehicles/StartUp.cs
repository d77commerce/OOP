using System;

namespace Vehicles
{
  public  class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]),double.Parse(carInfo[2]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]),double.Parse(truckInfo[2]));
            double carKm = 0;
            double truckKm = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string action = info[0];
                string typeVehcle = info[1];
                double value = double.Parse(info[2]);
                
                if (action == "Drive")
                {
                    if (typeVehcle == "Car")
                    {
                        car.Driven(value);
                    }
                    else if (typeVehcle=="Truck")
                    {
                        truck.Driven(value);
                    }

                }
                else if (action== "Refuel")
                {
                    if (typeVehcle == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (typeVehcle == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }


            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
