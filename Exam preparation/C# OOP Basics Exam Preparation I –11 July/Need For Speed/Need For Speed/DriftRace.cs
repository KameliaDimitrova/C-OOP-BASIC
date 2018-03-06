
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
        if (Participants.Count > 0)
        {
            foreach (var car in Participants)
            {
                car.PerformancePoints = (car.Suspension + car.Durability);
            }
            Participants=Participants.OrderByDescending(x => x.PerformancePoints).ToList();
            return base.ToString();
        }
        return $"Cannot start the race with zero participants{Environment.NewLine}";

    }
}
