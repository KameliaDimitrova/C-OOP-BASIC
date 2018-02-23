using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Problem8_Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            List<Car> cars=new List<Car>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeigth = int.Parse(input[3]);
                var cargoType = input[4];
                var tire1Presure = double.Parse(input[5]);
                var tire2Presure = double.Parse(input[7]);
                var tire3Presure = double.Parse(input[9]);
                var tire4Presure = double.Parse(input[11]);
                var tire1Age = int.Parse(input[6]);
                var tire2Age = int.Parse(input[8]);
                var tire3Age = int.Parse(input[10]);
                var tire4Age = int.Parse(input[12]);
                Engine currEngine=new Engine(engineSpeed,enginePower);
                Cargo currCargo=new Cargo(cargoWeigth,cargoType);
                List<Tires> tires=new List<Tires>();
                tires.Add(new Tires(tire1Presure,tire1Age));
                tires.Add(new Tires(tire2Presure, tire2Age));
                tires.Add(new Tires(tire3Presure, tire3Age));
                tires.Add(new Tires(tire4Presure, tire4Age));
                Car car=new Car(model,currEngine,currCargo,tires);
                 cars.Add(car);
            }
            var command = Console.ReadLine();
            if (command == "fragile")
            {
                var result = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.TirePresure < 1));
                foreach (var car in result)
                {
                   Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                var result = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower>250);
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
