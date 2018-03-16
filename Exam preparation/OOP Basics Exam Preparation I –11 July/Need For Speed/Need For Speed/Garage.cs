
using System.Collections.Generic;

public class Garage
{
    private List<int> parkedCars;

    public List<int> ParkedCars
    {
        get { return parkedCars; }
        private set { parkedCars = value; }
    }

    public Garage()
    {
        this.ParkedCars = new List<int>();
    }

    public void AddCar(int carId)
    {
        this.ParkedCars.Add(carId);
    }

    public void RemoveCar(int carId)
    {
        this.ParkedCars.Remove(carId);
    }
}

