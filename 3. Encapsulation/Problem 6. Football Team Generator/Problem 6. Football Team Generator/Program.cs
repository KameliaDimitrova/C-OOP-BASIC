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
            var inputOfCommand = "";
            while ((inputOfCommand = Console.ReadLine()) != "END")
            {
                try
                {
                    var splitCommand = inputOfCommand.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var command = splitCommand[0];
                    if (command != "Team" && !allTeams.Any(t => t.Name == splitCommand[1]))
                    {
                        throw new ArgumentException($"Team {splitCommand[1]} does not exist.");
                    }
                    switch (command)
                    {
                        case "Add":
                            stats = new Stats(decimal.Parse(splitCommand[3]), decimal.Parse(splitCommand[4]),
                                decimal.Parse(splitCommand[5]), decimal.Parse(splitCommand[6]),
                                decimal.Parse(splitCommand[7]));
                            player = new Player(splitCommand[2], stats);
                            allTeams.First(x => x.Name == splitCommand[1]).AddPlayer(player);
                            break;
                        case "Remove":
                            allTeams.Find(x => x.Name == splitCommand[1]).RemovePlayer(splitCommand[2]);
                            break;
                        case "Rating":
                            Console.WriteLine(allTeams.First(x => x.Name == splitCommand[1]).CalculateTeamRating());
                            break;
                        case "Team":
                            team = new Team(splitCommand[1]);
                            allTeams.Add(team);
                            break;
                        default: break;
                    }

                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }

            }
        }
    }
}
