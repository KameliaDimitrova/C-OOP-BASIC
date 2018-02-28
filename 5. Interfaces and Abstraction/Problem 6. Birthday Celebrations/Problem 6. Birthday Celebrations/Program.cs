using System;
using System.Collections.Generic;
using System.Linq;
using Problem6.Birthday_Celebrations;

namespace Problem5.Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LifeCreature> lifeCreatures=new List<LifeCreature>();
            AddLifeCreatures(lifeCreatures);
            var yearForCheck = Console.ReadLine();
            Console.Write(ChckIfYearExist(lifeCreatures, yearForCheck));
        }

        private static string ChckIfYearExist(List<LifeCreature> lifeCreatures, string yearForCheck)
        {
            var result = string.Empty;
            foreach (var creature in lifeCreatures)
            {
                if (creature.BirthDate.EndsWith(yearForCheck))
                {
                    result = result + creature.BirthDate + Environment.NewLine;
                }
            }
            return result;
        }

        public static void AddLifeCreatures(List<LifeCreature> lifeCreatures)
        {
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input
                    .Split(' ')
                    .ToList();
                if (tokens[0] == "Pet")
                {
                    lifeCreatures.Add(new Pet(tokens[1], tokens[2]));
                }
                else if(tokens[0]=="Citizen")
                {
                    lifeCreatures.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3],tokens[4]));
                }
            }
        }
    }
}
