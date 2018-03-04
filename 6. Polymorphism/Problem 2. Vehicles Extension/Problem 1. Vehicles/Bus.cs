
using System;

public class Bus:Vechils,IBus
{
    public const double INCREASE_BUS_CONSUMATION = 1.4;

    public Bus(double fuelQuantity, double literPerKm, double tankCapacity) : base(fuelQuantity, literPerKm, tankCapacity)
    { 
    }

    public Bus()
    {
    }

    public override string ToString()
    {
        return $"Bus: {FuelQuantity:f2}";
    }
}
