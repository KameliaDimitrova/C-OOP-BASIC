using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem10.Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars=new List<Car>();
            List<Engine> engines=new List<Engine>();
            Engine engine=new Engine();
            Car car=new Car();
            var n = double.Parse(Console.ReadLine());
            for (double i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.Trim())
                    .ToArray();
                var engineModel = input[0];
                var enginePower = double.Parse(input[1]);
                
                if (input.Length == 4)
                {
                    var engineDisplacement = double.Parse(input[2]);
                    var engineEfficiency = (input[3]);
                    engine=new Engine(engineModel,enginePower,engineDisplacement,engineEfficiency);
                   
                }
                else if (input.Length == 2)
                {
                    engine=new Engine(engineModel,enginePower);
                }
                else if (input.Length == 3)
                {
                    if (double.TryParse(input[2], out var engineEfficensy))
                    {
                        engine=new Engine(engineModel,enginePower,engineEfficensy);
                    }
                        else
                    {
                        var engineDisplacement = input[2];
                        engine=new Engine(engineModel,enginePower,engineDisplacement);
                       
                    }
                    
                }
                engines.Add(engine);

            }
            var m = double.Parse(Console.ReadLine());
            for (double i = 0; i < m; i++)
            {
                var input = Console.ReadLine()
                    .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.Trim())
                    .ToArray();
                var carModel = input[0];
                engine = engines.Find(x=>x.EngineModel==input[1]);

                if (input.Length == 4)
                {
                    var carWeigth = double.Parse(input[2]);
                    var carColor = input[3];
                    car = new Car(carModel,engine,carWeigth,carColor);

                }
                else if (input.Length == 2)
                {
                   car =new Car(carModel,engine);
                }
                else if (input.Length == 3)
                {
                    if (double.TryParse(input[2], out var carWeight))
                    {
                        car =new Car(carModel,engine,carWeight);
                    }
                    else
                    {
                        var carColor = input[2];
                       car=new Car(carModel,engine,carColor);
                    }

                }
                cars.Add(car);
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.CarModel}:");
                Console.WriteLine($"  {item.CarEngine.EngineModel}:");
                Console.WriteLine($"    Power: {item.CarEngine.EnginePower}");
                Console.Write($"    Displacement: ");
                if (item.CarEngine.EngineDisplacement == -1)
                {
                    Console.WriteLine("n/a");
                }
                else
                {
                    Console.WriteLine(item.CarEngine.EngineDisplacement);
                }
                Console.WriteLine($"    Efficiency: {item.CarEngine.EngineEfficiency}");
                Console.Write($"  Weight: ");
                if (item.CarWeigth == -1)
                {
                    Console.WriteLine("n/a");
                }
                else
                {
                    Console.WriteLine(item.CarWeigth);
                }
                Console.WriteLine($"  Color: {item.CarColor}");
            }
        }
    }
}
