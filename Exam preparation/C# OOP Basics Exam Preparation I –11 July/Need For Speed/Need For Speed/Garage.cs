
using System.Collections.Generic;

public class Garage
{
    private List<Car> parkedCars;

    public List<Car> ParkedCars
    {
        get { return parkedCars; }
        set { parkedCars = value; }
    }

    public Garage()
    {
        this.ParkedCars = new List<Car>();
    }

}

