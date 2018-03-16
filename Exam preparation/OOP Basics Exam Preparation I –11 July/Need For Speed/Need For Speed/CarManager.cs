
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
        private set { garage = value; }
    }
    public Dictionary<int, Car> Cars
    {
        get { return cars; }
        private set { cars = value; }
    }
    public Dictionary<int, Race> Races
    {
        get { return races; }
        private set { races = value; }
    }

    public CarManager()
    {
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case PERFORMANCE_CAR:
                this.cars[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case SHOW_CAR:
                this.cars[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            default:
                break;
        }
    }

    public string Check(int id)
    {
        return cars[id].ToString().Trim();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case CASUAL_RACE:
                this.races[id] = new CasualRace(length, route, prizePool);
                break;
            case DRAG_RACE:
                this.races[id] = new DragRace(length, route, prizePool);
                break;
            case DRIFT_RACE:
                this.races[id] = new DriftRace(length, route, prizePool);
                break;
            default:
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!garage.ParkedCars.Contains(carId))
        {
            this.races[raceId].Participants.Add(this.Cars[carId]);
        }
    }

    public string Start(int id)
    {
        if (this.races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        else
        {
            var result = races[id].Start();
            races.Remove(id);
            return result;
        }
    }

    public void Park(int id)
    {
        if (Races.Any(x => x.Value.Participants.Contains(Cars[id])))
        {
            return;
        }
        this.garage.AddCar(id);
    }

    public void Unpark(int id)
    {
        this.garage.RemoveCar(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var carId in this.garage.ParkedCars)
        {
            cars[carId].Tune(tuneIndex, addOn);
        }
    }
}

