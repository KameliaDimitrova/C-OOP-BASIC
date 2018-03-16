
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

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<Car>();
    }

    public virtual string Start()
    {
       
            var place = 1;
            var sb = new StringBuilder();
            Dictionary<int, int> places = new Dictionary<int, int>
            {
                {1,50},
                {2,30},
                {3,20}
            };
            sb.AppendLine($"{this.Route} - {this.Length}");
            foreach (var carPar in Participants)
            {
                sb.AppendLine($"{place}. {carPar.Brand} {carPar.Model} {carPar.PerformancePoints}PP - ${(PrizePool * places[place]) / 100}");
                place++;
                if (place == 4)
                {
                    break;
                }
            }
            return sb.ToString().Trim();
   
    }
}

