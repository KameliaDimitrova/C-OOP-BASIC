using System;
using System.Collections.Generic;
using System.Text;


public class Pockemon
{
    private string pokName;
    private string pokElement;
    private int pokHealth;

    public string PokName
    {
        get  => this.pokName;
        set => this.pokName = value;
    }
    public string PokElement
    {
        get => this.pokElement;
        set => this.pokElement = value;
    }
    public int PokHealth
    {
        get => this.pokHealth;
        set => this.pokHealth = value;
    }

    public Pockemon()
    {
    }

    public Pockemon(string name, string element, int health)
    {
        this.pokName = name;
        this.pokElement = element;
        this.pokHealth = health;
    }


}

