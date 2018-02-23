using System;

namespace Problem_1._Class_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = decimal.Parse(Console.ReadLine());
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());
            Box box = new Box(length, width, height);
            Console.WriteLine(box);
        }
    }
}
