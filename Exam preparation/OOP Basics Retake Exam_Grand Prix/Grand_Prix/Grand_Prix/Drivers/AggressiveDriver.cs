public class AggressiveDriver : Driver
{
    public AggressiveDriver(string name, Car car)
        : base(name, car)
    {
        this.FuelConsumptionPerKm = 2.7;
   }

    public override void Overtaking(Driver firstDriver, Driver secondDriver, string weather)
    {
        IsOvertaking = false;
        switch (secondDriver.Car.Tyre.Name)
        {
            case "Ultrasoft":
                if (secondDriver.TotalTime - firstDriver.TotalTime  <= 3)
                {
                    if (weather == "Foggy")
                    {
                        secondDriver.IsCrashed = true;
                        break;
                    }
                    firstDriver.TotalTime = firstDriver.TotalTime + 3;
                    secondDriver.TotalTime = secondDriver.TotalTime - 3;
                    IsOvertaking = true;
                }
                break;
            case "Hard":
                base.Overtaking(firstDriver, secondDriver, weather);
                break;
        }
    }

    public override void CompleteLap(int trackLength)
    {
        this.Speed = ((this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount) * 1.3;
        this.TotalTime = this.TotalTime + (60 / (trackLength / this.Speed));
        this.Car.FuelAmount = this.Car.FuelAmount - trackLength * this.FuelConsumptionPerKm;
        this.Car.Tyre.DegradateTyres();
    }
}

