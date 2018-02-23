using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem9.Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Rectangle> rectangles=new List<Rectangle>();
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => double.Parse(x))
                .ToArray();
            var n = numbers[0];
            var m = numbers[1];
            for (double i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var id = input[0];
                var width = double.Parse(input[1]);
                var height = double.Parse(input[2]);
                var topLeftX = double.Parse(input[3]);
                var topLeftY = double.Parse(input[4]);
                Rectangle rectangle=new Rectangle(id,width,height,topLeftX,topLeftY);
                rectangles.Add(rectangle);
            }
            for (double i = 0; i < m; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var firstRectangle = rectangles.FirstOrDefault(x=>x.Id==input[0]);
                var secondRectangle = rectangles.FirstOrDefault(x => x.Id == input[1]);
                Console.WriteLine((firstRectangle.IsTwoRectangleInsect(secondRectangle)).ToString().ToLower());

            }
        }
    }
}
