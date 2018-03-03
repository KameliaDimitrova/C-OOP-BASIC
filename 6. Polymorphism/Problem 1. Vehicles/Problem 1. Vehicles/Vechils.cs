
public class Vechils:ICar,ITruck
{
    private double fuelQuantity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    private double litersPerKm;

    public double LitersPerKm
    {
        get { return litersPerKm; }
        set { litersPerKm = value; }
    }

   public Vechils(double fuelQuantity, double literPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = literPerKm;
    }

    public virtual string DriveCar(double kmToDrive)
    {
        return "If there is a fuel, no problem!";
    }
    
    public virtual void RefuelCar(double fuel)
    {
    }
    public virtual string DriveTruck(double kmToDrive)
    {

        return "If there is a fuel, no problem!";
    }

    public virtual void RefuelTruck(double fuel)
    {
    }

}

