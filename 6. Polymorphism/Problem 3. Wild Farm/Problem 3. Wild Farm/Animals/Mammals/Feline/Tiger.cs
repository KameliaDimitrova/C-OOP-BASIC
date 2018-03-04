
using System;
using System.Collections.Generic;

public class Tiger:Feline
{
    private const string SOUND = "ROAR!!!";
    private const double WEIGTH_INCREASING = 1.00;
    private string breed;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

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
    public Tiger(string name, double weigth, string livingRegion, string breed)
        : base(name, weigth, livingRegion,breed)
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

