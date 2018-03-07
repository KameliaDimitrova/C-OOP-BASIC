
using System;
using System.Collections.Generic;
using System.Text;

public abstract class Race
{
    private int length;

    public int Length
    {
        get { return length; }
        protected set { length = value; }
    }

    private string route;

    public string Route
    {
        get { return route; }
        protected set { route = value; }
    }

    private int prizePool;

    public int PrizePool
    {
        get { return prizePool; }
        protected set { prizePool = value; }
    }

    private List<Car> participants;

    public List<Car> Participants
    {
        get { return participants; }
        protected set { participants = value; }
    }

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<Car>();
    }

    public virtual string Start()
    {
        if (Participants.Count > 0)
        {
            var place = 1;
            var sb = new StringBuilder();
            Dictionary<int, int> places = new Dictionary<int, int>
            {
                {1,50},
                {2,30},
                {3,20}
            };
            foreach (var carPar in Participants)
            {
                sb.Append($"{place}. {carPar.Brand} {carPar.Model} {carPar.PerformancePoints}PP - ${(PrizePool * places[place]) / 100}{Environment.NewLine}");
                place++;
                if (place == 4)
                {
                    break;
                }
            }
            return $"{this.route} - {this.length}{Environment.NewLine}" +
                   $"{sb}";
        }
        return $"Cannot start the race with zero participants.{Environment.NewLine}";
    }
}

