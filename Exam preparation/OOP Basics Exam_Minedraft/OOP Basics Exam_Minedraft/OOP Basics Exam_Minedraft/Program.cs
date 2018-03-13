using System;
using System.Linq;

namespace OOP_Basics_Exam_Minedraft
{
    class Program
    {
        static void Main(string[] args)
        {
            DraftManager draftManager = new DraftManager();
            bool isShutDown = false;
            var input = Console.ReadLine();
     
            while (!isShutDown)
            {
                var arguments = input
                    .Split(' ')
                    .ToList();
                var command = arguments[0];
                switch (command)
                {
                    case "RegisterHarvester":
                        Console.WriteLine(draftManager.RegisterHarvester(arguments.Skip(1).ToList()));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(draftManager.RegisterProvider(arguments.Skip(1).ToList()));
                        break;
                    case "Day":
                        Console.WriteLine(draftManager.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(draftManager.Mode(arguments.Skip(1).ToList()));
                        break;
                    case "Check":
                        Console.WriteLine(draftManager.Check(arguments.Skip(1).ToList()));
                        break;
                    case "Shutdown":
                        Console.WriteLine(draftManager.ShutDown());
                        isShutDown = true;
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
