﻿
public class Truck : Vechils
{
    public Truck(double fuelQuantity, double literPerKm) : base(fuelQuantity, literPerKm)
    {
        this.LitersPerKm = this.LitersPerKm + 1.6;
    }

    public override string DriveTruck(double kmToDrive)
    {
        if (this.FuelQuantity >= kmToDrive * this.LitersPerKm)
        {
            this.FuelQuantity = this.FuelQuantity - kmToDrive * this.LitersPerKm;
            return $"Truck travelled {kmToDrive} km";
        }
        else
        {
            return $"Truck needs refueling";
        }
    }

    public override void RefuelTruck(double fuel)
    {
        this.FuelQuantity = this.FuelQuantity + (fuel * 0.95);
    }

    public override string ToString()
    {
        return $"Truck: {FuelQuantity:f2}";
    }
}

