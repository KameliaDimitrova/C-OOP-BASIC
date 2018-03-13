
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {

    }
    public override string Start()
    {
        foreach (var car in Participants)
        {
            car.GetOverallPerformance(car);
        }
        Participants = Participants.OrderByDescending(x => x.PerformancePoints).ToList();
        return base.Start();
    }
}

