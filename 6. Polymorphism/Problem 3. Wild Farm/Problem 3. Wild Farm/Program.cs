using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Wild_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal animal = new Animal();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split(' ').ToList();
                var animalType = animalTokens[0];
                switch (animalType)
                {
                    case "Hen":
                        animal = new Hen(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));
                        animals.Add(animal);
                        Console.WriteLine(animal.ProduceSound());
                        break;
                    case "Owl":
                        animal = new Owl(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));
                        animals.Add(animal);
                        Console.WriteLine(animal.ProduceSound());
                        break;
                    case "Mouse":
                        animal = new Mouse(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                        animals.Add(animal);
                        Console.WriteLine(animal.ProduceSound());
                        break;
                    case "Cat":
                        animal = new Cat(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                        animals.Add(animal);
                        Console.WriteLine(animal.ProduceSound());
                        break;
                    case "Dog":
                        animal = new Dog(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                        animals.Add(animal);
                        Console.WriteLine(animal.ProduceSound());
                        break;
                    case "Tiger":
                        animal = new Tiger(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                        animals.Add(animal);
                        Console.WriteLine(animal.ProduceSound());
                        break;
                    default:
                        break;
                }
                var feedAnimals = Console.ReadLine().Split(' ').ToList();
                var food = feedAnimals[0];
                var quantity = int.Parse(feedAnimals[1]);
                animal.IncreaseWeigth(food, quantity);

            }
            foreach (var anim in animals)
            {
                Console.WriteLine(anim);
            }
        }
    }
}
