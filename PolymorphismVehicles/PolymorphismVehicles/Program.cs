using System;

namespace PolymorphismVehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputCar = Console.ReadLine().Split(" ");
            var inputTruck = Console.ReadLine().Split(" ");
            var inputBUS = Console.ReadLine().Split(" ");
            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]), double.Parse(inputCar[3]));
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]), double.Parse(inputTruck[3]));
            Bus bus = new Bus(double.Parse(inputBUS[1]), double.Parse(inputBUS[2]), double.Parse(inputBUS[3]));
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] action = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string comand = action[0];
                string typeVehicle = action[1];
                double argument = double.Parse(action[2]);
                switch (comand)
                {
                    case "Drive":
                        if (typeVehicle == "Car")
                        {
                            car.Drive(argument);

                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Drive(argument);

                        }
                        else if(typeVehicle == "Bus")
                        {
                            bus.Drive(argument);    
                        }
                        break;
                    case "DriveEmpty":

                        bus.DriveEmpty(argument);
                        break;
                    case "Refuel":
                        if (typeVehicle == "Car")
                        {
                            car.Refil(argument);
                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Refil(argument);
                        }
                        else if (typeVehicle == "Bus")
                        {
                            bus.Refil(argument);
                        }
                        break;

                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
