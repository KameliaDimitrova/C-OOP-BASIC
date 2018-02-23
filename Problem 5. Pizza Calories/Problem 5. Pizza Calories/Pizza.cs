using System;
using System.Collections.Generic;
using System.Text;


public class Pizza
{
    private string name;

    public string Name
    {
        get { return name; }
        private set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    private Dough dough;

    public Dough Dough
    {
        get { return dough; }
        private set { dough = value; }
    }

    private List<Topping> toppings;

    public List<Topping> Toppings
    {
        get { return toppings; }
        private set { toppings = value; }

    }

    public Pizza()
    {
    }

    public Pizza(string name)
    {
        this.Name = name;
        this.toppings = new List<Topping>();
    }

    public void AddDough(Dough dough)
    {
        this.Dough = dough;
    }

    public void AddTopping(Topping topping)
    {
        this.Toppings.Add(topping);
        if (toppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public decimal CalculatePizzaCalories()
    {
        var toppingsCalorie = 0M;
        foreach (var topping in toppings)
        {
            toppingsCalorie = toppingsCalorie + topping.CalculateToppingCalories();
        }
        return toppingsCalorie + this.dough.CalculateDoughCaloriews();
    }

    public override string ToString()
    {
        return $"{this.name} - {CalculatePizzaCalories():f2} Calories.";
    }
}

