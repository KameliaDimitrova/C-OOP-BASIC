using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            var inputOfbuyers = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var inputOfProducts = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < inputOfbuyers.Count - 1; i += 2)
            {
                try
                {
                    Person person = new Person(inputOfbuyers[i], decimal.Parse(inputOfbuyers[i + 1]));
                    persons.Add(person);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                    return;
                }
            }
            for (int j = 0; j < inputOfProducts.Count - 1; j += 2)
            {
                try
                {
                    Product product = new Product(inputOfProducts[j], decimal.Parse(inputOfProducts[j + 1]));
                    products.Add(product);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                    return;
                }
            }

            var input = Console.ReadLine();
            while (input != "END")
            {
                var data = input.Split(' ');
                Console.WriteLine(persons.Find(x => x.Name == data[0])
                             .WantedToBuySomethig(products.Find(x => x.Name == data[1])));

                input = Console.ReadLine();

            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

        }
    }
}
