
using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public List<string> AddOns
    {
        get { return addOns; }
       private set { addOns = value; }
    }

    public PerformanceCar(string brand, string model, int yearOfproduction, int horsepower, int acceleration,
        int suspension,int durability)
        : base(brand, model, yearOfproduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.Horsepower = this.Horsepower +this.Horsepower *50/100;
        this.Suspension = this.Suspension - this.Suspension *25/100;
    }

   
    public override string ToString()
    {
        var addOnsResult = String.Empty;
        if (addOns.Count == 0)
        {
            addOnsResult = "None";
        }
        else
        {
            addOnsResult = String.Join(", ", addOns);
        }
        return $"{base.ToString()}" +
               $"Add-ons: {addOnsResult}{Environment.NewLine}";

    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.AddOns.Add(addOn);
    }
}

