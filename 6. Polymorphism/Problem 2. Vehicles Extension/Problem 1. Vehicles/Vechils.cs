
using System;

public class Vechils
{
    private double fuelQuantity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set
        {
            fuelQuantity = value;
        }
    }

    private double litersPerKm;

    public double LitersPerKm
    {
        get { return litersPerKm; }
        set { litersPerKm = value; }
    }

    private double tankCapacity;

    public double TanckCapacity
    {
        get { return tankCapacity; }
        set
        {
            if (value < fuelQuantity)
            {
                this.FuelQuantity = 0;
            }
            tankCapacity = value;
        }
    }

    public void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            Console.WriteLine($"Fuel must be a positive number");
            return;
        }
        if (fuel + this.FuelQuantity > this.TanckCapacity)
        {
            Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            return;
        }
        if (this.GetType() == typeof(Truck))
        {
            this.FuelQuantity = this.FuelQuantity + 0.95*fuel;
        }
        else
        this.FuelQuantity = this.FuelQuantity + fuel;
    }

    public string Drive(double kmToDrive,string vehil,double increaseConsumation)
    {
        if (this.FuelQuantity >= kmToDrive * (this.LitersPerKm+increaseConsumation))
        {
            this.FuelQuantity = this.FuelQuantity - kmToDrive * (this.LitersPerKm+increaseConsumation);
            return $"{vehil} travelled {kmToDrive} km";
        }
        else
        {
            return $"{vehil} needs refueling";
        }
    }
    public Vechils(double fuelQuantity, double literPerKm,double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = literPerKm;
        this.TanckCapacity = tankCapacity;
    }

    public Vechils()
    {
    }


}

