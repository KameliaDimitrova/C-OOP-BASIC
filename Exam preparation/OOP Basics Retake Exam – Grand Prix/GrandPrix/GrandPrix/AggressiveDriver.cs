public class AggressiveDriver : Driver
{
    public AggressiveDriver(string name,Car car)
        :base(name,car)
    {
        this.FuelConsumptionPerKm = 2.7;
        this.Speed = car.GetCarSpeed() * 1.3;
    }
}

