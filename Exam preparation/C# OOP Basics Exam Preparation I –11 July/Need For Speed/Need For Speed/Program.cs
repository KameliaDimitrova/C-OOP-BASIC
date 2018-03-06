using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_For_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager=new CarManager();
            List<int> IdOfClosedRaces=new List<int>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "Cops Are Here")
            {
                var inputTokens = input
                    .Split(' ')
                    .ToList();
                var command = inputTokens[0];
                switch (command)
                {
                    case "register":
                        carManager.Register(int.Parse(inputTokens[1]),inputTokens[2],inputTokens[3],inputTokens[4],int.Parse(inputTokens[5]),int.Parse(inputTokens[6]),int.Parse(inputTokens[7]),int.Parse(inputTokens[8]),int.Parse(inputTokens[9]));
                        break;
                    case "check":
                       Console.Write(carManager.Check(int.Parse(inputTokens[1])));
                        break;
                    case "open":
                        carManager.Open(int.Parse(inputTokens[1]),inputTokens[2],int.Parse(inputTokens[3]),inputTokens[4],int.Parse(inputTokens[5]));
                        break;
                    case "participate":
                        if (!IdOfClosedRaces.Contains(int.Parse(inputTokens[1])))
                        {
                            carManager.Participate(int.Parse(inputTokens[1]), int.Parse(inputTokens[2]));
                        }
                        break;
                    case "start":
                        if (!IdOfClosedRaces.Contains(int.Parse(inputTokens[1])))
                        {
                            Console.Write(carManager.Start(int.Parse(inputTokens[1])));
                            IdOfClosedRaces.Add(int.Parse(inputTokens[1]));
                        }
                        break;
                    case "park":
                        carManager.Park(int.Parse(inputTokens[1]));
                        break;
                    case "unpark":
                        carManager.Unpark(int.Parse(inputTokens[1]));
                        break;
                    case "tune":
                        carManager.Tune(int.Parse(inputTokens[1]),inputTokens[2]);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
