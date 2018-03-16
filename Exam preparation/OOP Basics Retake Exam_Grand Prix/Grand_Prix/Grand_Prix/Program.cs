using System;
using System.Linq;

namespace GrandPrix
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceTower racetower = new RaceTower();

            var numberOfLaps = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            racetower.SetTrackInfo(numberOfLaps, length);

                while (racetower.RaceIsOver == false)
                {
                    var input = Console.ReadLine().Split(' ').ToList();
                    var command = input[0];
                    switch (command)
                    {
                        case "RegisterDriver":
                            racetower.RegisterDriver(input.Skip(1).ToList());
                            break;
                        case "Leaderboard":
                            Console.WriteLine(racetower.GetLeaderboard());
                            break;
                        case "CompleteLaps":
                            var result = racetower.CompleteLaps(input.Skip(1).ToList());
                            if (result.Length!=0)
                            {
                                Console.WriteLine(result);
                            }
                            break;
                        case "Box":
                            racetower.DriverBoxes(input.Skip(1).ToList());
                            break;
                        case "ChangeWeather":
                            racetower.ChangeWeather(input.Skip(1).ToList());
                            break;
                    }
                }
            }


        
    }
}
