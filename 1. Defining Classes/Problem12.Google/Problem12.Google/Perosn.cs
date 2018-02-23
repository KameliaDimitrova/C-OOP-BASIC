using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


public class Perosn
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parents> parents;
    private List<Children> childrens;
    private Car car;


    public Perosn(string personName)
    {
        this.name = personName;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parents>();
        this.childrens = new List<Children>();
        this.company = new Company();
        this.car = new Car();
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public Company Company
    {
        get => this.company;
        set => this.company = value;
    }

    public List<Parents> Parent
    {
        get => this.parents;
        set => this.parents = value;
    }

    public List<Children> Childrens
    {
        get => this.childrens;
        set => this.childrens = value;
    }

    public List<Pokemon> Pokemon
    {
        get => this.pokemons;
        set => this.pokemons = value;
    }

    public Car Car
    {
        get => this.car;
        set => this.car = value;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.Name);
        sb.AppendLine($"Company:");
        if (this.Company.CompName != null)
        {
            sb.AppendLine($"{this.Company.CompName} {this.Company.CompDepartment} {this.Company.CompSalary:F2}");
        }

        sb.AppendLine($"Car:");

        if (this.Car.CarModel != null)
        {
            sb.AppendLine($"{this.Car.CarModel} {this.Car.CarSpeed}");
        }

        sb.AppendLine($"Pokemon:");
        foreach (var pokemon in this.Pokemon)
        {
            sb.AppendLine($"{pokemon.PokeName} {pokemon.PokeType}");
        }

        sb.AppendLine($"Parents:");
        foreach (var parent in this.Parent)
        {
            sb.AppendLine($"{parent.ParentName} {parent.ParentBirthday}");
        }

        sb.AppendLine($"Children:");
        foreach (var child in this.Childrens)
        {
            sb.AppendLine($"{child.ChildrenName} {child.ChildrenBirthday}");
        }

        return sb.ToString().Trim();
    }
}
   

  



