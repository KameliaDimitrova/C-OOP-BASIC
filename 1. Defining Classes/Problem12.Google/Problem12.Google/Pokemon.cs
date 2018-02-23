using System;
using System.Collections.Generic;
using System.Text;

public class Pokemon
{
    private string pokeName;
    private string pokeType;

    public Pokemon(string name, string type)
    {
        this.pokeName = name;
        this.pokeType = type;
    }

    public string PokeName
    {
        get => this.pokeName;
        set => this.pokeName = value;
    }

    public string PokeType
    {
        get => this.pokeType;
        set => this.pokeType = value;
    }

    public Pokemon()
    {
    }

}