using System.Collections.Generic;

public abstract class Driver
{

    private double totalTime;
    private Car car;
    private double fuelConsumptionPerKm;
    private double speed;
    private bool isCrashed;
    private bool isOvertaking;

  
    public string Name { get;  }

    public double TotalTime
    {
        get { return totalTime; }
        set { totalTime = value; }
    }

    public Car Car
    {
        get { return car; }
        private set { car = value; }
    }

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        protected set { fuelConsumptionPerKm = value; }
    }

    public virtual double Speed
    {
        get { return speed; }
        protected set
        {
            speed = value;
        }
    }

    public bool IsCrashed
    {
        get { return isCrashed; }
        set { isCrashed = value; }
    }

    public bool IsOvertaking
    {
        get { return isOvertaking; }
        set { isOvertaking = value; }
    }


    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.Car = car;
        this.TotalTime = 0;
        this.IsCrashed = false;
        this.IsOvertaking = false;
    }

    public virtual void CompleteLap(int trackLength)
    {
        this.Speed = (this.car.Hp + this.car.Tyre.Degradation) / this.car.FuelAmount;
        this.TotalTime = this.TotalTime + (60 / (trackLength / this.Speed));
        this.Car.FuelAmount = this.Car.FuelAmount - trackLength * this.FuelConsumptionPerKm;
        this.Car.Tyre.DegradateTyres();
    }

    public virtual void Overtaking(Driver firstDriver, Driver secondDriver, string weather)
    {
        IsOvertaking = false;
        if (secondDriver.TotalTime - firstDriver.TotalTime <= 2)
        {
            firstDriver.TotalTime = firstDriver.TotalTime + 2;
            secondDriver.TotalTime = secondDriver.TotalTime - 2;
            IsOvertaking = true;
        }
    }

    public void BoxCommand(List<string> arguments)
    {
        var reason = arguments[0];
        this.TotalTime = this.TotalTime + 20;
        switch (reason)
        {
            case "Refuel":
                this.Car.FuelAmount = this.Car.FuelAmount + double.Parse(arguments[2]);
                break;
            case "ChangeTyres":
                var type = arguments[2];
                switch (type)
                {
                    case "Hard":
                        this.Car.Tyre = new HardTyre(double.Parse(arguments[3]));
                        break;
                    case "Ultrasoft":
                        this.Car.Tyre = new UltrasoftTyre(double.Parse(arguments[2]), double.Parse(arguments[3]));
                        break;
                }
                break;
            default: break;
        }
    }

}
