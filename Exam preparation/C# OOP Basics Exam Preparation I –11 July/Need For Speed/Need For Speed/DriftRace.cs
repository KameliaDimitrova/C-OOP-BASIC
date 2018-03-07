
using System;
using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {

    }
    public override string Start()
    {
        foreach (var car in Participants)
        {
            car.GetSuspensionPerformance(car);
        }
        Participants = Participants.OrderByDescending(x => x.PerformancePoints).ToList();
        return base.Start();
    }
}
