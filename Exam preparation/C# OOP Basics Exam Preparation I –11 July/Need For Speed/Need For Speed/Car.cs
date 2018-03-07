
using System;
using System.ComponentModel.Design;

public abstract class Car
{
    private string brand;

    public string Brand
    {
        get { return brand; }
        protected set { brand = value; }
    }

    private string model;

    public string Model
    {
        get { return model; }
        protected set { model = value; }
    }

    private int yearOfProduction;

    public int YearOfProduction
    {
        get { return yearOfProduction; }
        protected set { yearOfProduction = value; }
    }

    private int horsepower;

    public int Horsepower
    {
        get { return horsepower; }
        protected set { horsepower = value; }
    }

    private int acceleration;

    public int Acceleration
    {
        get { return acceleration; }
        protected set { acceleration = value; }
    }

    private int suspension;

    public int Suspension
    {
        get { return suspension; }
        protected set { suspension = value; }
    }

    private int durability;

    public int Durability
    {
        get { return durability; }
        protected set { durability = value; }
    }
    private int performancePoints;

    public int PerformancePoints
    {
        get { return performancePoints; }
        protected set { performancePoints = value; }
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

    public void GetOverallPerformance(Car car)
    {
        car.PerformancePoints = car.Horsepower / car.Acceleration + (car.Suspension + car.Durability);
    }

    public void GetEnginePerformance(Car car)
    {
        car.performancePoints=car.Horsepower / car.Acceleration;
    }

    public void GetSuspensionPerformance(Car car)
    {
        car.performancePoints = car.Suspension + car.Durability;
    }
    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.Horsepower = this.Horsepower + tuneIndex;
        this.Suspension = this.Suspension + tuneIndex * 50 / 100;
    }
}
