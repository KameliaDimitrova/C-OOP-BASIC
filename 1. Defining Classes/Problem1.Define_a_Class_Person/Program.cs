using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Define_a_Class_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family=new Family();
            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);
                family.AddMember(new Person(name,age));
            }

            List<Person> moreThan30 = family.GetFamilyMembersMoreThan30Years();
            for (int i = 0; i < moreThan30.Count; i++)
            {
                Console.WriteLine(moreThan30[i].Name+" - "+moreThan30[i].Age);
            }
        }
    }
}
