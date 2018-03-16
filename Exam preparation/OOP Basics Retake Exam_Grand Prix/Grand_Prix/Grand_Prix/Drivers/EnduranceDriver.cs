public class EnduranceDriver : Driver
{
    public EnduranceDriver(string name, Car car)
        : base(name, car)
    {
        this.FuelConsumptionPerKm = 1.5;
    }

    public override void Overtaking(Driver firstDriver, Driver secondDriver, string weather)
    {
        IsOvertaking = false;

        switch (secondDriver.Car.Tyre.Name)
        {
            case "Ultrasoft":
                base.Overtaking(firstDriver, secondDriver, weather);
                break;
            case "Hard":
                if (secondDriver.TotalTime - firstDriver.TotalTime <= 3)
                {
                    if (weather == "Rainy")
                    {
                        secondDriver.IsCrashed = true;
                        break;
                    }
                    firstDriver.TotalTime = firstDriver.TotalTime + 3;
                    secondDriver.TotalTime = secondDriver.TotalTime - 3;
                    IsOvertaking = true;
                }
                break;
        }
    }

}

