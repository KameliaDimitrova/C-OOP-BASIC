
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private const string PERFORMANCE_CAR = "Performance";
    private const string SHOW_CAR = "Show";
    private const string CASUAL_RACE = "Casual";
    private const string DRAG_RACE = "Drag";
    private const string DRIFT_RACE = "Drift";

    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public Garage Garage
    {
        get { return garage; }
        set { garage = value; }
    }
    public Dictionary<int, Car> Cars
    {
        get { return cars; }
        set { cars = value; }
    }
    public Dictionary<int, Race> Races
    {
        get { return races; }
        set { races = value; }
    }

    public CarManager()
    {
        this.Cars=new Dictionary<int, Car>();
        this.Races=new Dictionary<int, Race>();
        this.Garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case PERFORMANCE_CAR:
                this.Cars[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case SHOW_CAR:
                this.Cars[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            default:
                break;
        }
    }

    public string Check(int id)
    {
        return Cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case CASUAL_RACE:
                this.Races[id] = new CasualRace(length, route, prizePool);
                break;
            case DRAG_RACE:
                this.Races[id] = new DragRace(length, route, prizePool);
                break;
            case DRIFT_RACE:
                this.Races[id] = new DriftRace(length, route, prizePool);
                break;
            default:
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (garage.ParkedCars.Contains(Cars[carId]))
        {
            return;
        }
        this.Races[raceId].Participants.Add(this.Cars[carId]);
    }

    public string Start(int id)
    {
        return Races[id].Start();
    }

    public void Park(int id)
    {
        if(Races.Any(x=>x.Value.Participants.Contains(Cars[id])))
        {
            return;
        }
        garage.ParkedCars.Add(this.Cars[id]);
    }

   public void Unpark(int id)
   {
       garage.ParkedCars.Remove(this.Cars[id]);
   }

   public void Tune(int tuneIndex, string addOn)
    {
        foreach (var pCars in garage.ParkedCars)
        {
            pCars.Horsepower = pCars.Horsepower + tuneIndex;
            pCars.Suspension = pCars.Suspension + tuneIndex / 2;
            if (pCars.GetType() == typeof(ShowCar))
            {
               var showCar= pCars as ShowCar;
                showCar.Stars = showCar.Stars+ tuneIndex;
            }
            else if (pCars.GetType() == typeof(PerformanceCar))
            {
                var performanceCar = pCars as PerformanceCar;
                performanceCar.AddOns.Add(addOn);
            }
        }
    }


}

