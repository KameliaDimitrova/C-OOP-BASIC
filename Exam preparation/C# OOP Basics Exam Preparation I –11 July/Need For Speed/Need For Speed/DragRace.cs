
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {

    }

    public override string Start()
    {
        if (Participants.Count > 0)
        {
            foreach (var car in Participants)
            {
                car.PerformancePoints = car.Horsepower / car.Acceleration;
            }
            Participants = Participants.OrderByDescending(x => x.PerformancePoints).ToList();
            return base.ToString();
        }

        return $"Cannot start the race with zero participants{Environment.NewLine}";
    }

}

