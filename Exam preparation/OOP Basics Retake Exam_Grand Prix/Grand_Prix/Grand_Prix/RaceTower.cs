using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private int lapsNumber;
    private int trackLength;
    private List<Driver> drivers;
    private string weather;
    private int completedLaps;
    private Dictionary<Driver, string> crashedDrivers;
    private bool raceIsOver;

    public bool RaceIsOver
    {
        get { return raceIsOver; }
        set { raceIsOver = value; }
    }


    public int CompletedLaps
    {
        get { return completedLaps; }
        set
        {
            if (value > this.lapsNumber)
            {
                throw new ArgumentException($"There is no time! On lap {completedLaps}.");
            }
            completedLaps = value;
        }
    }


    public RaceTower()
    {
        this.drivers = new List<Driver>();
        this.weather = "Sunny";
        this.crashedDrivers = new Dictionary<Driver, string>();
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.lapsNumber = lapsNumber;
        this.trackLength = trackLength;
    }
    public void RegisterDriver(List<string> commandArgs)
    {

        var driverType = commandArgs[0];
        var tyreType = commandArgs[4];
        try
        {

            switch (tyreType)
            {
                case "Hard":
                    var hardTyre = new HardTyre(double.Parse(commandArgs[5]));
                    var car = new Car(int.Parse(commandArgs[2]), double.Parse(commandArgs[3]), hardTyre);
                    switch (driverType)
                    {
                        case "Aggressive":
                            var agressiveDriver = new AggressiveDriver(commandArgs[1], car);
                            drivers.Add(agressiveDriver);
                            break;
                        case "Endurance":
                            var eduranceDriver = new EnduranceDriver(commandArgs[1], car);
                            drivers.Add(eduranceDriver);
                            break;
                        default:
                            break;
                    }
                    break;

                case "Ultrasoft":
                    var ultrasoftTyre = new UltrasoftTyre(double.Parse(commandArgs[5]), double.Parse(commandArgs[6]));
                    var car2 = new Car(int.Parse(commandArgs[2]), double.Parse(commandArgs[3]), ultrasoftTyre);
                    switch (driverType)
                    {
                        case "Aggressive":
                            var agressiveDriver = new AggressiveDriver(commandArgs[1], car2);
                            drivers.Add(agressiveDriver);
                            break;
                        case "Endurance":
                            var enduranceDriver = new EnduranceDriver(commandArgs[1], car2);
                            drivers.Add(enduranceDriver);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        catch (Exception)
        {
            return;
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var name = commandArgs[1];
        var driver = drivers.First(x => x.Name == name);
        driver.BoxCommand(commandArgs);
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var sb=new StringBuilder();
        var numberOfLaps = int.Parse(commandArgs[0]);
        var counterLaps = this.completedLaps;
        try
        {
            this.CompletedLaps = counterLaps + numberOfLaps;
        }
        catch (ArgumentException argEx)
        {
            return argEx.Message;
        }

        for (int i = counterLaps; i < this.CompletedLaps; i++)
        {
            for (int j = 0; j < drivers.Count; j++)
            {
                var driver = drivers[j];
                try
                {
                    driver.CompleteLap(trackLength);
                }
                catch (ArgumentException argEx)
                {
                    crashedDrivers[driver] = argEx.Message;
                    drivers.Remove(driver);
                    j--;
                }
            }
            if (i + 1 == this.lapsNumber)
            {
                drivers = drivers.OrderBy(x => x.TotalTime).ToList();
                IsOver();
                return $"{drivers[0].Name} wins the race for {drivers[0].TotalTime:f3} seconds.";
            }
            drivers = drivers.OrderByDescending(x => x.TotalTime).ToList();
            for (int m = 0; m < drivers.Count - 1; m += 2)
            {
                var secondDriver = drivers[m];
                var firstDriver = drivers[m + 1];
                secondDriver.Overtaking(firstDriver, secondDriver, weather);
                if (secondDriver.IsOvertaking)
                {
                    sb.AppendLine($"{secondDriver.Name} has overtaken {firstDriver.Name} on lap {i + 1}.");
                }
                if (secondDriver.IsCrashed)
                {
                    drivers.Remove(secondDriver);
                    crashedDrivers[secondDriver] = "Crashed";
                }
            }
        }
        return sb.ToString().Trim();
    }

    public string GetLeaderboard()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Lap {this.completedLaps}/{this.lapsNumber}");
        drivers = drivers.OrderBy(x => x.TotalTime).ToList();
        var position = 1;
        foreach (var driver in drivers)
        {
            sb.AppendLine($"{position} {driver.Name} {driver.TotalTime:f3}");
            position++;
        }

        foreach (var crashedDriver in crashedDrivers.Reverse())
        {
            sb.AppendLine($"{position} {crashedDriver.Key.Name} {crashedDriver.Value}");
            position++;
        }
        return sb.ToString().Trim();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        var weather = commandArgs[0];
        this.weather = weather;
    }
    public void IsOver()
    {
        raceIsOver = true;
    }

}

