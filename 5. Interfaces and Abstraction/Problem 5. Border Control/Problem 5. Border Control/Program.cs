using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5.Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
           List<IEnter> enters=new List<IEnter>();
           AddCitizenAndRobots(enters);
           var idForCheck = Console.ReadLine();
           Console.WriteLine(CheckForId(enters,idForCheck));
        }

        private static string CheckForId(List<IEnter> enters,string idForCheck)
        {
            var result = string.Empty;
            foreach (var enter in enters)
            {
                if (enter.Id.EndsWith(idForCheck))
                {
                    result = result + enter.Id + Environment.NewLine;
                }
            }
            return result;
        }

        public static void AddCitizenAndRobots(List<IEnter> enters)
        {
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input
                    .Split(' ')
                    .ToList();
                if (tokens.Count == 2)
                {
                    enters.Add(new Robot(tokens[0], tokens[1]));
                }
                else
                {
                    enters.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }
        }
    }
}
