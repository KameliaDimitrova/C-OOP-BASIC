﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Explicit_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> allCitizens=new List<Citizen>();
            var input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input
                    .Split(' ')
                    .ToList();
                var name = tokens[0];
                var country = tokens[1];
                var age = int.Parse(tokens[2]);
                Citizen citizen=new Citizen(name,country,age);
                allCitizens.Add(citizen);
            }
            foreach (var citizen in allCitizens)
            {
                Console.WriteLine(citizen.Name);
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
