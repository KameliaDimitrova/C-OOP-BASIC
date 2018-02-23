using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumation;
    public decimal distanceTraveled;
    public string Model
    {
        get => this.model;
        set => this.model = value;
    }
    public decimal FuelAmount
    {
        get => this.fuelAmount;
        set => this.fuelAmount = value;
    }
    public decimal FuelConsumation
    {
        get => this.fuelConsumation;
        set => this.fuelConsumation = value;
    }
    public decimal DistanceTraveled
    {
        get => this.distanceTraveled;
        set => this.distanceTraveled = value;
    }

    public Car(string model, decimal fuelAmount,decimal fuelConsumation)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumation = fuelConsumation;
        distanceTraveled = 0;
    }

    public bool IsTheCarCanMoveTheDistance(string model, decimal amountOfKm)
    {
        var needFuel = amountOfKm * fuelConsumation;
        if (needFuel <= fuelAmount)
        {
            fuelAmount = fuelAmount - needFuel;
            distanceTraveled = distanceTraveled+amountOfKm;
            return true;

        }
        return false;
    }
}

