using System;
using System.Linq;

namespace GrandPrix
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceTower racetower=new RaceTower();

            var numberOfLaps = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            racetower.SetTrackInfo(numberOfLaps,length);

            try
            {
                while (racetower.RaceIsOver == false)
                {
                    var input = Console.ReadLine().Split(' ').ToList();
                    var command = input[0];
                    switch (command)
                    {
                        case "RegisterDriver":
                            racetower.RegisterDriver(input);
                            break;
                        case "Leaderboard":
                           Console.WriteLine(racetower.GetLeaderboard());
                            break;
                        case "CompleteLaps":
                           Console.WriteLine(racetower.CompleteLaps(input));
                            break;
                        case "Box":
                            racetower.DriverBoxes(input);
                            break;
                        case "ChangeWeather":
                            racetower.ChangeWeather(input);
                            break;
                    }
                }
            }
            catch (ArgumentException argsEx)
            {
                Console.WriteLine(argsEx.Message);
                throw;
            }
           
        }
    }
}
