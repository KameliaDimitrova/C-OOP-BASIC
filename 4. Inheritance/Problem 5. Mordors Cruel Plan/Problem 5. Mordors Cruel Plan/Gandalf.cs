using System;
using System.Collections.Generic;
using System.Text;


public class Gandalf
{
    private readonly Dictionary<string, int> foodForHappiness = new Dictionary<string, int>()
    {
        {"cram", 2},
        {"lembas", 3},
        {"apple", 1},
        {"melon", 1},
        {"honeycake", 5},
        {"mushrooms", -10},
    };


    private int pointsOfHappiness;

    public int PointsOfHappiness
    {
        get { return pointsOfHappiness; }
        set { pointsOfHappiness = value; }
    }

    public Gandalf()
    {
    }

    public void EatFood(string food)
    {
        if (foodForHappiness.ContainsKey(food.ToLower()))
        {
            this.pointsOfHappiness = this.pointsOfHappiness + foodForHappiness[food.ToLower()];
        }
        else
        {
            this.pointsOfHappiness = this.pointsOfHappiness - 1;
        }
    }

    public string GetGandalfMood()
    {
        if (this.pointsOfHappiness < -5)
            return "Angry";
        if (this.pointsOfHappiness <= 0)
            return "Sad";
        if (this.pointsOfHappiness <= 15)
            return "Happy";
        else
            return "JavaScript";
    }

    public override string ToString()
    {
        return $"{this.pointsOfHappiness}{Environment.NewLine}" +
               $"{GetGandalfMood()}{Environment.NewLine}";
    }
}



