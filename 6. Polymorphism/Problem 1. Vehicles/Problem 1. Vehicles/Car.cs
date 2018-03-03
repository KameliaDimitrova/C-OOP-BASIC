
public class Car:Vechils
{
    public Car(double fuelQuantity, double literPerKm) : base(fuelQuantity, literPerKm)
    {
        this.LitersPerKm = this.LitersPerKm + 0.9;
    }

    public override string DriveCar(double kmToDrive)
    {
        if (this.FuelQuantity >= kmToDrive * this.LitersPerKm)
        {
            this.FuelQuantity = this.FuelQuantity - kmToDrive * this.LitersPerKm;
            return $"Car travelled {kmToDrive} km";
        }
        else
        {
            return $"Car needs refueling";
        }
    }

    public override void RefuelCar(double fuel)
    {
        this.FuelQuantity = this.FuelQuantity + fuel;
    }

    public override string ToString()
    {
        return $"Car: {FuelQuantity:f2}";
    }
}

