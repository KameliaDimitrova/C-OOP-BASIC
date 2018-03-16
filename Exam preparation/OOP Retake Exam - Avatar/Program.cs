using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Retake_Exam___Avatar
{
    class Program
    {
        static void Main(string[] args)
        {
            NationsBuilder nationsBuilder=new NationsBuilder();
            var input = Console.ReadLine();
            bool isQuit = false;
            while (isQuit == false) 
            {
                var inputArguments = input
                    .Split(' ')
                    .ToList();

                var command = inputArguments[0];
                switch (command)
                {
                    case "Bender":
                        nationsBuilder.AssignBender(inputArguments.Skip(1).ToList());
                        break;
                    case "Monument":
                        nationsBuilder.AssignMonument(inputArguments.Skip(1).ToList());
                        break;
                    case "Status":
                       Console.WriteLine(nationsBuilder.GetStatus(inputArguments[1]));
                        break;
                    case "War":
                        nationsBuilder.IssueWar(inputArguments[1]);
                        break;
                    case "Quit":
                        isQuit = true;
                        Console.WriteLine(nationsBuilder.GetWarsRecord());
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
