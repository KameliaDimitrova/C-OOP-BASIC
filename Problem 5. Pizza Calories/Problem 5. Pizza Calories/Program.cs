using System;
using System.Linq;

namespace Problem_5._Pizza_Calories
{
    class Program
    {
        static void Main(string[] args)
        {

            Dough dough = new Dough();
            Topping topping = new Topping();
            Pizza pizza=new Pizza();

            var pizzaInput = Console.ReadLine().Split(' ').ToList();
            try
            {
                pizza=new Pizza(pizzaInput[1]);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
                return;
            }
            var doughInput = Console.ReadLine().Split(' ').ToList();
            var flourType = doughInput[1];
            var backingTechnique = doughInput[2];
            var doughWeigth = decimal.Parse(doughInput[3]);
            try
            {
                dough = new Dough(flourType, backingTechnique, doughWeigth);
                pizza.AddDough(dough);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
                return;
            }
  
            var input = Console.ReadLine();
            while (input != "END")
            {
                var toppingInput = input.Split(' ').ToList();
                var toppingType = toppingInput[1];
                var toppingWeigth = decimal.Parse(toppingInput[2]);
                try
                {
                    topping=new Topping(toppingType,toppingWeigth);
                    pizza.AddTopping(topping);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(pizza);
        }
    }
}
