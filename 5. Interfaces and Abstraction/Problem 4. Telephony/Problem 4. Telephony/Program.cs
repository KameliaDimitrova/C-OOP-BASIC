using System;
using System.Linq;

namespace Problem4.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneForCalling = Console.ReadLine()
                .Split(' ')
                .ToList();

            var siteForBrowse = Console.ReadLine()
                .Split(' ')
                .ToList();
            Smartphone smartphone=new Smartphone(phoneForCalling,siteForBrowse);
            Console.WriteLine(smartphone);
        }
    }
}
