using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Problem1.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechils> vehiles = new List<Vechils>();
            Car car=new Car();
            Truck truck=new Truck();
            Bus bus=new Bus();
            for (int i = 1; i < 4; i++)
            {
                var inputData= Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var vechil = inputData[0];
                var fuelQuantity = double.Parse(inputData[1]);
                var fuelPerKm = double.Parse(inputData[2]);
                var tankCapacity = double.Parse(inputData[3]);
                switch (vechil)
                {
                    case "Car":
                        car = new Car(fuelQuantity, fuelPerKm, tankCapacity);
                        vehiles.Add(car);
                        break;
                    case "Truck":
                        truck =new Truck(fuelQuantity,fuelPerKm,tankCapacity);
                        vehiles.Add(truck);
                        break;
                    case "Bus":
                        bus=new Bus(fuelQuantity,fuelPerKm,tankCapacity);
                        vehiles.Add(bus);
                        break;
                    default: break;
                }
            }

            var numberOfCommand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommand; i++)
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var currCommand = command[0];
                var vechil = command[1];
                var quantity = double.Parse(command[2]);
                switch (currCommand)
                {
                    case "Drive":
                        switch (vechil)
                        {
                            case "Car":
                                Console.WriteLine(car.Drive(quantity,"Car",0));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.Drive(quantity,"Truck",0));
                                break;
                            case "Bus":
                                Console.WriteLine(bus.Drive(quantity,"Bus",Bus.INCREASE_BUS_CONSUMATION));
                                break;
                            default: break;
                        }
                        break;
                    case "Refuel":
                        switch (vechil)
                        {
                            case "Car":
                                car.Refuel(quantity);
                                break;
                            case "Truck":
                                truck.Refuel(quantity);
                                break;
                            case "Bus":
                                bus.Refuel(quantity);
                                break;
                            default: break;
                        }
                        break;
                    case "DriveEmpty":
                        Console.WriteLine(bus.Drive(quantity,"Bus",0));
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
