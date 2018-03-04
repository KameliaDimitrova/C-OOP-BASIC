
using System;
using System.Collections.Generic;

public class Owl:Bird
{
    private const string SOUND = "Hoot Hoot";
    private const double WEIGTH_INCREASING = 0.25;

    private List<string> foods;

    public List<string> Foods
    {
        get { return foods; }
        set
        {
            foods = new List<string>();
            foods.Add("Meat");
        }
    }

    public Owl(string name, double weight, double wingSize)
        : base(name, weight,  wingSize)
    {
        this.Foods = foods;
    }
    public override string ProduceSound()
    {
        return SOUND;
    }
    public override void IncreaseWeigth(string foodName, int quantity)
    {
        if (this.foods.Contains(foodName))
        {
            this.Weight = this.Weight + quantity * WEIGTH_INCREASING;
            this.FoodEaten = this.FoodEaten + quantity;
        }
        else
        {
            Console.WriteLine($"{this.GetType()} does not eat {foodName}!");
        }
    }
}

