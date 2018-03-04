
using System;

public class Car:Vechils,ICar
{
    public Car(double fuelQuantity, double literPerKm,double tankCapacity) : base(fuelQuantity, literPerKm,tankCapacity)
    {
        this.LitersPerKm = this.LitersPerKm + 0.9;
    }

    public Car()
    {
    }

    public override string ToString()
    {
        return $"Car: {FuelQuantity:f2}";
    }
}

