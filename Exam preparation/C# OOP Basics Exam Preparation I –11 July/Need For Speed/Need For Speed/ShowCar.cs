
using System;
using System.Collections.Generic;

public class ShowCar : Car
{
    private int stars;

    public int Stars
    {
        get { return stars; }
        set { stars = value; }
    }

    public ShowCar(string brand, string model, int yearOfproduction, int horsepower, int acceleration,
        int suspension,int durability)
        : base(brand, model, yearOfproduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public override string ToString()
    {
        return $"{base.ToString()}" +
               $"{stars} *{Environment.NewLine}";
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
       this.Stars = this.Stars + tuneIndex;
    }
}

