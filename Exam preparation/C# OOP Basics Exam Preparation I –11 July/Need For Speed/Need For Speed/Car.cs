
using System;

public abstract class Car
{
    private string brand;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private int yearOfProduction;

    public int YearOfProduction
    {
        get { return yearOfProduction; }
        set { yearOfProduction = value; }
    }

    private int horsepower;

    public int Horsepower
    {
        get { return horsepower; }
        set { horsepower = value; }
    }

    private int acceleration;

    public int Acceleration
    {
        get { return acceleration; }
        set { acceleration = value; }
    }

    private int suspension;

    public int Suspension
    {
        get { return suspension; }
        set { suspension = value; }
    }

    private int durability;

    public int Durability
    {
        get { return durability; }
        set { durability = value; }
    }
    private int performancePoints;

    public int PerformancePoints
    {
        get { return performancePoints; }
        set { performancePoints = value; }
    }

    public Car(string brand, string model, int yearOfproduction, int horsepower, int acceleration, int suspension,
        int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfproduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public override string ToString()
    {
        return $"{this.brand} {this.model} {this.yearOfProduction}{Environment.NewLine}" +
               $"{this.horsepower} HP, 100 m/h in {this.acceleration} s{Environment.NewLine}" +
               $"{this.suspension} Suspension force, {this.durability} Durability{Environment.NewLine}";
    }
}
