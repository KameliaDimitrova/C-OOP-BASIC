using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem_8._Military_Elite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();
            List<Private> allPrivates = new List<Private>();
            
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input
                    .Split(' ')
                    .ToList();

                switch (tokens[0])
                {
                    case "Private":
                        Private privat = new Private(int.Parse(tokens[1]), tokens[2], tokens[3],
                            double.Parse(tokens[4]));
                        allPrivates.Add(privat);
                        soldiers.Add(privat);
                        break;
                    case "LeutenantGeneral":
                        var listOfprivates = new List<Private>();
                        LeutenantGeneral general = new LeutenantGeneral(int.Parse(tokens[1]), tokens[2], tokens[3],
                            double.Parse(tokens[4]), listOfprivates);
                        for (int i = 5; i < tokens.Count; i++)
                        {
                            var id = int.Parse(tokens[i]);
                            listOfprivates.Add(allPrivates.Find(x => x.Id == id));
                        }
                        general.Privates = listOfprivates;
                        soldiers.Add(general);
                        break;
                    case "Engineer":
                        if (tokens[5] != "Airforces" && tokens[5] != "Marines")
                        {
                           continue;
                        }
                        var repairs = new Dictionary<string, int>();
                            Engineer engeneer = new Engineer(int.Parse(tokens[1]), tokens[2], tokens[3],
                                double.Parse(tokens[4]), tokens[5], repairs);
                            for (int i = 6; i < tokens.Count - 1; i += 2)
                            {
                                repairs[tokens[i]] = int.Parse(tokens[i + 1]);
                            }
                            engeneer.Repairs = repairs;
                            soldiers.Add(engeneer);
                        break;
                    case "Commando":
                        if (tokens[5] != "Airforces" && tokens[5] != "Marines")
                        {
                            continue;
                        }
                        var missions = new Dictionary<string, string>();
                        Commando commando = new Commando(int.Parse(tokens[1]), tokens[2], tokens[3],
                            double.Parse(tokens[4]), tokens[5], missions);
                        for (int i = 6; i < tokens.Count - 1; i += 2)
                        {
                            if (tokens[i + 1] == "inProgress" || tokens[i + 1] == "Finished")
                            {
                                missions[tokens[i]] = tokens[i + 1];
                            }
                        }
                        commando.Missions = missions;
                       soldiers.Add(commando);
                        break;
                    case "Spy":
                        Spy spy = new Spy(int.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4]));
                        soldiers.Add(spy);
                        break;
                     default: break;
                }
            }

            foreach (var solger in soldiers)
            {
                Console.WriteLine(solger);
            }
        }
    }
}
