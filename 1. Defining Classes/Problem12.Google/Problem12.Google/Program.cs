using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem12.Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Perosn> persons=new Dictionary<string, Perosn>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var data = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                var name = data[0];
                var item = data[1];
                if (!persons.ContainsKey(name))
                {
                    persons[name]=new Perosn(name);
                }
                if (item == "company")
                {
                    if (persons[name].Company == null)
                    {
                        persons[name].Company = new Company(data[2], data[3], decimal.Parse(data[4]));
                    }
                    else
                    {
                        persons[name].Company.LastAdedCompani(data[2], data[3],decimal.Parse(data[4]));
                    }
                }
                else if (item == "parents")
                {
                    persons[name].Parent.Add(new Parents(data[2],data[3]));
                }
                else if (item == "pokemon")
                {
                    persons[name].Pokemon.Add(new Pokemon(data[2], data[3]));
                }
                else if (item == "children")
                {
                    persons[name].Childrens.Add(new Children(data[2], data[3]));
                }
                else if (item == "car")
                {
                    if (persons[name].Car == null)
                    {
                        persons[name].Car = new Car(data[2], int.Parse(data[3]));
                    }
                    else
                    {
                        persons[name].Car.LastAdedCar(data[2],int.Parse(data[3]));
                    }
                }
                    input = Console.ReadLine();
                }
            var inputName = Console.ReadLine();
            Perosn wantedPerson = persons[inputName];
            Console.WriteLine(wantedPerson.ToString());
        }
    }
}
