
using System;
using System.Collections.Generic;

public class Mouse : Mammal
{
    private const string SOUND = "Squeak";
    private const double WEIGTH_INCREASING = 0.1;

    private List<string> foods;

    public List<string> Foods
    {
        get { return foods; }
        set
        {
            foods = new List<string>();
            foods.Add("Vegetable");
            foods.Add("Fruit");
        }
    }

    public Mouse(string name, double weigth,  string livingRegion)
        : base(name, weigth, livingRegion)
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

