
using System;
using System.Collections.Generic;

public class Hen : Bird
{
    private const string SOUND = "Cluck";
    private const double WEIGTH_INCREASING = 0.35;
    private double wingSize;

    public double WingSize
    {
        get { return wingSize; }
        set { wingSize = value; }
    }

    private List<string> foods;

    public List<string> Foods
    {
        get { return foods; }
        set
        {
            foods = new List<string>();
            foods.Add("Vegetable");
            foods.Add("Meat");
            foods.Add("Fruit");
            foods.Add("Seeds");
        }
    }

    public Hen(string name, double weight,  double wingSize)
        : base(name, weight,  wingSize)
    {
        this.WingSize = wingSize;
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

