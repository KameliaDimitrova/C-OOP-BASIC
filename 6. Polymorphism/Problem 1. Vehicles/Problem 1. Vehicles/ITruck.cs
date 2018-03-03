
public interface ITruck
{
    double FuelQuantity { get; set; }
    double LitersPerKm { get; set; }
    string DriveTruck(double kmToDrive);
    void RefuelTruck(double fuel);
}

