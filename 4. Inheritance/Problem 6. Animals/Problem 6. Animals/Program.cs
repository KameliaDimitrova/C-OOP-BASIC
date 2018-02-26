using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_6._Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    ReadAndCreateAnimals(animals, animalType);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }
            PrintTheInformationForAllAnimals(animals);
        }

        private static void ReadAndCreateAnimals(List<Animal> animals, string animalType)
        {
            var tokens = Console.ReadLine()
                .Split();
            var animalName = tokens[0];
            var age = int.Parse(tokens[1]);
            switch (animalType)
            {
                case "Cat":
                    Cat cat = new Cat(animalName, age, tokens[2]);
                    animals.Add(cat);
                    break;
                case "Dog":
                    Dog dog = new Dog(animalName, age, tokens[2]);
                    animals.Add(dog);
                    break;
                case "Frog":
                    Frog frog = new Frog(animalName, age, tokens[2]);
                    animals.Add(frog);
                    break;
                case "Kitten":
                    Kitten kiten = new Kitten(animalName, age);
                    animals.Add(kiten);
                    break;
                case "Tomcat":
                    Tomcat tomcat = new Tomcat(animalName, age);
                    animals.Add(tomcat);
                    break;
                default:
                   throw new ArgumentException("Invalid input!");
            }
        }

        private static void PrintTheInformationForAllAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.Write(animal);
            }
        }
    }
}

