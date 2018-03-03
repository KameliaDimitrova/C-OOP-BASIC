using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechils> vehiles = new List<Vechils>();
            var carData = Console.ReadLine()
                .Split(' ')
                .ToList();
            var fuelQuantity = double.Parse(carData[1]);
            var fuelPerKm = double.Parse(carData[2]);
            Car car = new Car(fuelQuantity, fuelPerKm);
            vehiles.Add(car);
            var truckData = Console.ReadLine()
                .Split(' ')
                .ToList();
            var fuelQuantityTruck = double.Parse(truckData[1]);
            var fuelPerKmTruck = double.Parse(truckData[2]);
            Truck truck = new Truck(fuelQuantityTruck, fuelPerKmTruck);
            vehiles.Add(truck);
            var numberOfCommand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommand; i++)
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var currCommand = command[0];
                var vechil = command[1];
                switch (currCommand)
                {
                    case "Drive":
                        switch (vechil)
                        {
                            case "Car":
                                Console.WriteLine(car.DriveCar(double.Parse(command[2])));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.DriveTruck(double.Parse(command[2])));
                                break;
                            default: break;
                        }
                        break;
                    case "Refuel":
                        switch (vechil)
                        {
                            case "Car":
                                car.RefuelCar(double.Parse(command[2]));
                                break;
                            case "Truck":
                                truck.RefuelTruck(double.Parse(command[2]));
                                break;
                            default: break;
                        }
                        break;
                    default: break;
                }
            }
            for (int i = 0; i < vehiles.Count; i++)
            {
                Console.WriteLine(vehiles[i]);
            }
        }
    }
}
