using System;
using System.Collections.Generic;

public class Dog : Mammal
{
    private const string SOUND = "Woof!";
    private const double WEIGTH_INCREASING = 0.4;

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

    public Dog(string name, double weigth, string livingRegion)
        : base(name, weigth,  livingRegion)
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

