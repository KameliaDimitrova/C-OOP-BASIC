using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Problem_6._Football_Team_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            Player player = new Player();
            Stats stats = new Stats();
            List<Team> allTeams = new List<Team>();
            
            var inputOfCommand = Console.ReadLine();
            while (inputOfCommand != "END")
            {
                var splitCommand = inputOfCommand.Split(new []{';'},StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = splitCommand[0];
                switch (command)
                {
                    case "Add":
                        try
                        {
                            stats = new Stats(decimal.Parse(splitCommand[3]), decimal.Parse(splitCommand[4]),
                                decimal.Parse(splitCommand[5]), decimal.Parse(splitCommand[6]),
                                decimal.Parse(splitCommand[7]));
                            player = new Player(splitCommand[2], stats);
                            if (allTeams.All(x => x.Name != splitCommand[1]))
                            {
                                Console.WriteLine($"Team {splitCommand[1]} does not exist.");
                            }
                            else
                            {
                                allTeams.First(x => x.Name == splitCommand[1]).AddPlayer(player);
                            }
                        }
                        catch (ArgumentException argEx)
                        {
                            Console.WriteLine(argEx.Message);
                        }
                        break;

                    case "Remove":
                        try
                        {
                            allTeams.Find(x=>x.Name==splitCommand[1]).RemovePlayer(splitCommand[2]);
                        }
                        catch (ArgumentException argEx)
                        {
                            Console.WriteLine(argEx.Message);
                        }
                        break;

                    case "Rating":
                        try
                        {
                            if (allTeams.All(x => x.Name != splitCommand[1]))
                            {
                                Console.WriteLine($"Team {splitCommand[1]} does not exist.");
                            }
                            else
                            {
                               Console.WriteLine(allTeams.First(x => x.Name == splitCommand[1]).CalculateTeamRating());
                            }
                        }
                        catch (ArgumentException argEx)
                        {
                            Console.WriteLine(argEx.Message);
                        }
                        break;

                    case "Team":
                        try
                        {
                            team = new Team(splitCommand[1]);
                            allTeams.Add(team);
                        }
                        catch (ArgumentException argEx)
                        {
                            Console.WriteLine(argEx.Message);
                        }
                        break;
                    default: break;
                }
                inputOfCommand = Console.ReadLine();
            }
        }
    }
}
