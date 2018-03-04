
using System;

public class Truck : Vechils,ITruck
{
    public Truck(double fuelQuantity, double literPerKm,double tankCapacity) : base(fuelQuantity, literPerKm,tankCapacity)
    {
        this.LitersPerKm = this.LitersPerKm + 1.6;
    }

    public Truck()
    {
    }

    public override string ToString()
    {
        return $"Truck: {FuelQuantity:f2}";
    }

}

