using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7._Food_Shortage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people=new List<People>();
            var numberOfPeople = int.Parse(Console.ReadLine());
            AddAllPeople(people,numberOfPeople);
            ByingFoods(people);
            Console.WriteLine(TotalAmountOfFoodPurshased(people));
        }

        private static int TotalAmountOfFoodPurshased(List<People> people)
        {
            var totalAmount = 0;
            foreach (var peop in people)
            {
                totalAmount = totalAmount + peop.Food;
            }
            return totalAmount;
        }

        private static void ByingFoods(List<People> people)
        {
            var buyerName = string.Empty;
            var totalAmountOfFood = 0;
            while ((buyerName = Console.ReadLine()) != "End")
            {
                if (people.Any(x => x.Name == buyerName))
                {
                    people.Find(x=>x.Name==buyerName).BuyFood();
                }
            }
        }

        private static void AddAllPeople(List<People> people, int numberOfPeople)
        {
            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                if (input.Count == 4)
                {
                    people.Add(new Citizen(input[0],int.Parse(input[1]),input[2],input[3]));
                }
                else if(input.Count==3)
                {
                    people.Add(new Rebel(input[0],int.Parse(input[1]),input[2]));
                }
            }
        }
    }
}
