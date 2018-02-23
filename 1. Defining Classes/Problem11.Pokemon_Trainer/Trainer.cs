using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Trainer
{
    private string trainerName;
    private int numberOfPoke;
    private int badgets;
    private List<Pockemon> pokemons;

    public string tTrainerName
    {
        get => this.trainerName;
        set => this.trainerName = value;
    }

    public int NumberOfPoke
    {
        get => this.numberOfPoke;
        set => this.numberOfPoke = value;
    }

    public int Badgets
    {
        get => this.badgets;
    }

    public List<Pockemon> Pokemons
    {
        get => this.pokemons;
    }

    public Trainer()
    {
    }

    public Trainer(string name, Pockemon pokemon)
    {
        this.trainerName = name;
        this.pokemons=new List<Pockemon>();
        this.pokemons.Add(pokemon);
        this.badgets = 0;
        this.numberOfPoke = pokemons.Count;
    }

    public bool CheckIfThereIsAPokeWithTheElement(string element)
    {
        var counter = 0;
        foreach (var poke in pokemons)
        {
            if (poke.PokElement == element)
            {
                counter++;
            }
        }
        if (counter >=1)
        {
            this.badgets++;
            return true;
        }
        else
        {
            foreach (var poke in pokemons.ToList())
            {
                poke.PokHealth = poke.PokHealth - 10;
                if (poke.PokHealth <= 0)
                {
                    this.pokemons.Remove(poke);
                    this.NumberOfPoke = pokemons.Count;
                }
            }
            return false;
        }
    }

    public void AddPockemon(Pockemon pokemon)
    {
       this.Pokemons.Add(pokemon);
        this.NumberOfPoke = pokemons.Count;
    }
  

}

