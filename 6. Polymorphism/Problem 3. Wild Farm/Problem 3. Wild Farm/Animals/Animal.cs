
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Animal
{
    private string name;

    public string  Name
    {
        get { return name; }
        set { name = value; }
    }

    private double weight;

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private int foodEaten;
    
    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }

    public Animal()
    {
    }

    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
    }

    public virtual string ProduceSound()
    {
        return "All animals produsing a different sounds";
    }

    public virtual void IncreaseWeigth(string foodName, int quantity)
    {
        
    }
}

