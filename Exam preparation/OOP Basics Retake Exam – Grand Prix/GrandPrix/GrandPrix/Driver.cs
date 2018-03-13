
using System.Collections.Generic;

public abstract class Driver
{
    private string name;

    public string Name
    {
        get { return name; }
    }

    private double totalTime;

    public double TotalTime
    {
        get { return totalTime; }
    }
    private bool isCrashed;

    public bool IsCrashed
    {
        get { return isCrashed; }
        set { isCrashed = value; }
    }


    private Car car;

    public Car Car
    {
        get { return car; }
    }
    private double fuelConsumptionPerKm;

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
       protected set { fuelConsumptionPerKm = value; }
    }

    private double speed;

    public double Speed
    {
        get { return speed; }
       protected set { speed = value; }
    }

    protected Driver(string name,Car car)
    {
        this.name = name;
        this.car = car;
        this.totalTime = 0;
        this.IsCrashed = false;
    }

    public void Box(List<string> commandArgs)
    {
        var boxReason = commandArgs[1];
        switch (boxReason)
        {
            case "Refuel":
                this.car.AddFuel(commandArgs[3]);
                break;
            case "ChangeTyres":
               this.car.ChangeTyres(commandArgs);
                break;
            default:
                break;
        }
        this.totalTime = this.TotalTime + 20;
    }

    public void GetTotalTime(int laps, int trackLength)
    {
        for (int i = 1; i <= laps; i++)
        {
            this.totalTime =this.totalTime+ 60 / (trackLength / this.car.GetCarSpeed());
        }
    }

    public void ReduceFuelAmount(int laps,int trackLength)
    {
         for (int i = 1; i <= laps; i++)
         {
             this.car.FuelAmount = this.car.FuelAmount - trackLength * this.FuelConsumptionPerKm;
         }
    }

    public void TheDriverCrashed()
    {
        this.isCrashed = true;
    }

}

