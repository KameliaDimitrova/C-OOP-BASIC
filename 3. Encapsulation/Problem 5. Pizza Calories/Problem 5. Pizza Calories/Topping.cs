using System;
using System.Collections.Generic;
using System.Text;

public class Topping
{
    private const string MEAT = "meat";
    private const string VEGGIES = "veggies";
    private const string CHEESE = "cheese";
    private const string SAUCE = "sauce";
    private const decimal MEAT_MODIFIER = (decimal)1.2;
    private const decimal VEGGIES_MODIFIER = (decimal)0.8;
    private const decimal CHEESE_MODIFIER = (decimal)1.1;
    private const decimal SAUCE_MODIFIER = (decimal)0.9;


    private string type;

    public string Type
    {
        get { return type; }
        set
        {
            if (value.ToLower() != MEAT && value.ToLower() != VEGGIES && value.ToLower() != CHEESE && value.ToLower() != SAUCE)
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value;
        }
    }


    private decimal weigth;

    public decimal Weigth
    {
        get { return weigth; }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
            }
            weigth = value;
        }
    }

    public Topping()
    {
    }

    public Topping(string type, decimal weigth)
    {
        this.Type = type;
        this.Weigth = weigth;
    }

    public decimal CalculateToppingCalories()
    {
        var typeModifier = 0M;
        switch (this.type.ToLower())
        {
            case MEAT:
                typeModifier = MEAT_MODIFIER;
                break;
            case VEGGIES:
                typeModifier = VEGGIES_MODIFIER;
                break;
            case CHEESE:
                typeModifier = CHEESE_MODIFIER;
                break;
            case SAUCE:
                typeModifier = SAUCE_MODIFIER;
                break;
        }

        return ((2 * this.weigth) * typeModifier);
    }
}

