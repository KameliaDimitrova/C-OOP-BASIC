using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars=new List<Car>();
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var model = input[0];
                var fuelAmount = decimal.Parse(input[1]);
                var fuelConsumation = decimal.Parse(input[2]);
                Car car=new Car(model,fuelAmount,fuelConsumation);
                cars.Add(car);
            }
            var secondInput= Console.ReadLine();
            while (secondInput != "End")
            {
                var data = secondInput
                    .Split(' ')
                    .ToArray();
                var modelToMove = data[1];
                var kmToMove = decimal.Parse(data[2]);

                if (!cars.First(x => x.Model == modelToMove).IsTheCarCanMoveTheDistance(modelToMove, kmToMove))
                {
                   Console.WriteLine("Insufficient fuel for the drive");
                }
                secondInput = Console.ReadLine();
            }
            foreach (var currCar in cars)
            {
                
                Console.WriteLine($"{currCar.Model} {currCar.FuelAmount:f2} {currCar.distanceTraveled:f0}");
            }
         
        }
    }
}
