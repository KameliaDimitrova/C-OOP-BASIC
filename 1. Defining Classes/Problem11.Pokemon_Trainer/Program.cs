using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem11.Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers=new List<Trainer>();
            List<Pockemon> pokemons=new List<Pockemon>();
            Trainer trainer=new Trainer();
            Pockemon pokemon=new Pockemon();
            var input = Console.ReadLine();
            while (input != "Tournament")
            {
                var data = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                var trainerName = data[0];
                var pokeName = data[1];
                var pokeElement = data[2];
                var pokeHealth = int.Parse(data[3]);
                pokemon=new Pockemon(pokeName,pokeElement,pokeHealth);
                pokemons.Add(pokemon);
                if(trainers.Any(x=>x.tTrainerName==trainerName))
                {
                    trainer = trainers.First(x => x.tTrainerName == trainerName);
                    trainer.AddPockemon(pokemon);
                }
                else
                {
                    trainer = new Trainer(trainerName, pokemon);
                    trainers.Add(trainer);
                }
                input = Console.ReadLine();
            }
            var element = Console.ReadLine();
            while (element != "End")
            {
                foreach (var trainee in trainers)
                {
                    trainee.CheckIfThereIsAPokeWithTheElement(element);
                }
                element = Console.ReadLine();
            }
            foreach (var trainee in trainers.OrderByDescending(x=>x.Badgets))
            {
                Console.WriteLine($"{trainee.tTrainerName} {trainee.Badgets} {trainee.NumberOfPoke}");
            }

        }
    }
}
