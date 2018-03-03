
public class Vechils
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
}

