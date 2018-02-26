using System;
using System.Linq;

namespace Problem_5._Mordor_s_Cruel_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Gandalf gandalf=new Gandalf();
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();
            for (int i = 0; i < input.Count; i++)
            {
                gandalf.EatFood(input[i]);
            }

            Console.Write(gandalf);
        }
    }
}
