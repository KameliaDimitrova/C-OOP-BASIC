using System;

namespace Problem_3._Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverName = Console.ReadLine();
            Ferrari ferrari=new Ferrari(driverName);
            Console.WriteLine(ferrari);
        }
    }
}
