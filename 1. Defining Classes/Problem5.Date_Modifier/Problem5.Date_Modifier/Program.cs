using System;

namespace Problem5.Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModifier data=new DataModifier();
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            Console.WriteLine(data.CalculatesTheDifferenceBetweeenTwoDate(firstDate,secondDate));
            
        }
    }
}
