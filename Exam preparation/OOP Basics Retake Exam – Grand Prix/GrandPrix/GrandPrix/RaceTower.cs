using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private string weather;

    public string Weather
    {
        get { return weather; }
        set { weather = value; }
    }
    private bool raceIsOver;

    public bool RaceIsOver
    {
        get { return raceIsOver; }
        set { raceIsOver = false; }
    }


    private Track track;

    public Track Track
    {
        get { return track; }
        set { track = value; }
    }
    public RaceTower()
    {
        this.Weather = "Sunny";
        this.drivers=new List<Driver>();
    }

    private List<Driver> drivers;

    public List<Driver> Drivers
    {
        get { return drivers; }
        set { drivers = value; }
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.Track = new Track(lapsNumber, trackLength);
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        var tyreType = commandArgs[5];
        Tyre tyre = null;
        Driver driver = null;
        switch (tyreType)
        {
            case "Ultrasoft":
                tyre = new UltrasoftTyre(double.Parse(commandArgs[6]), double.Parse(commandArgs[7]));
                break;
            case "Hard":
                tyre = new HardTyre(double.Parse(commandArgs[6]));
                break;
            default:
                break;
        }
        Car car = new Car(int.Parse(commandArgs[3]), double.Parse(commandArgs[4]), tyre);
        var driverType = commandArgs[1];
        switch (driverType)
        {
            case "Aggressive":
                driver = new AggressiveDriver(commandArgs[2], car);
                break;
            case "Endurance":
                driver = new EnduranceDriver(commandArgs[2], car);
                break;
            default:
                break;
        }
        drivers.Add(driver);
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        this.drivers.First(x => x.Name == commandArgs[2]).Box(commandArgs);
    }

    public string CompleteLaps(List<string> commandArgs)
    {
     
        var numberOfLaps = int.Parse(commandArgs[1]);
        if (numberOfLaps+this.track.CurrLapsNumber > this.track.LapsNumber)
        {
            return "There is no time! On lap 0.";
        }
        this.Track.CurrLapsNumber = this.Track.CurrLapsNumber + numberOfLaps;
        foreach (var driver in drivers)
        {
            driver.GetTotalTime(numberOfLaps, this.Track.Length);
            driver.ReduceFuelAmount(numberOfLaps, this.Track.Length);
            driver.Car.Tyre.DegradateTyre(numberOfLaps);
        }
        drivers = drivers.OrderByDescending(x => x.TotalTime).ToList();
        for (int i = 0; i < drivers.Count - 1; i += 2)
        {
            var driverType = "";
            var tyreType = "";
            if (drivers[i].GetType() == typeof(AggressiveDriver))
            {
                driverType = "AggressiveDriver";
            }
            else
                driverType = "EnduranceDriver";
            if (drivers[i].Car.Tyre.GetType() == typeof(UltrasoftTyre))
            {
                tyreType = "UltrasoftTyre";
            }
            else
                tyreType = "HardTyre";
            if (driverType == "AggressiveDriver" && tyreType == "UltrasoftTyre")
            {
                if (drivers[i + 1].TotalTime - drivers[i].TotalTime <= 3)
                {
                    if (weather == "Foggy")
                    {
                        this.drivers[0].TheDriverCrashed();
                    }
                    else
                    {
                        return
                            $"{this.drivers[i].Name} has overtaken {this.drivers[i + 1].Name} on lap {numberOfLaps}.";
                    }

                }
            }
            else if (driverType == "EnduranceDriver" && tyreType == "HardTyre")
            {
                if (drivers[i + 1].TotalTime - drivers[i].TotalTime <= 3)
                {
                    if (weather == "Rainy")
                    {
                        this.drivers[0].TheDriverCrashed();
                    }
                    else
                    {
                        return
                            $"{this.drivers[i].Name} has overtaken {this.drivers[i + 1].Name} on lap {numberOfLaps}.";
                    }

                }
            }
            else
            {
                if (drivers[i + 1].TotalTime - drivers[i].TotalTime <= 2)
                {
                    return
                        $"{this.drivers[i].Name} has overtaken {this.drivers[i + 1].Name} on lap {numberOfLaps}.";
                }
            }
        }
        if (track.CurrLapsNumber == track.LapsNumber)
        {
           IsOver();
            return $"{drivers[0].Name} wins the race for {drivers[0].TotalTime:f3} seconds.";
        }
       return $"";
    }

    public string GetLeaderboard()
    {
        var sb = new StringBuilder();
        var counter = 1;
        sb.AppendLine($"{this.Track.CurrLapsNumber}/{this.track.LapsNumber}");
        drivers = drivers.OrderByDescending(x => x.TotalTime).ToList();
        foreach (var driver in Drivers)
        {
            if (driver.IsCrashed)
            {
                //// sb.AppendLine($"{counter} {driver.Name} {driver}");
            }
            else
            {
                sb.AppendLine($"{counter} {driver.Name} {driver.TotalTime}");
                counter++;
            }
        }
        return sb.ToString().Trim();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        this.Weather = commandArgs[1];
    }

    public void IsOver()
    {
        raceIsOver = true;
    }

}

