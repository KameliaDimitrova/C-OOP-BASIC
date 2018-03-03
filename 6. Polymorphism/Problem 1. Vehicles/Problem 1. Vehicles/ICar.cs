public interface ICar  
{
    double FuelQuantity { get; set; }
    double LitersPerKm { get; set; }
    string DriveCar(double kmToDrive);
    void RefuelCar(double fuel);
}
