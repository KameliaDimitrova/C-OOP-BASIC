
using System;
using System.Collections.Generic;

public abstract class Race
{
    private int length;

    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    private string route;

    public string Route
    {
        get { return route; }
        set { route = value; }
    }

    private int prizePool;

    public int PrizePool
    {
        get { return prizePool; }
        set { prizePool = value; }
    }

    private List<Car> participants;

    public List<Car> Participants
    {
        get { return participants; }
        set { participants = value; }
    }

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<Car>();
    }

    public override string ToString()
    {
        return $"{this.route} - {this.length}{Environment.NewLine}";
        //1. {brand} {model} {performancePoints}PP - ${moneyWon}
        //o    2. { brand}
        //{ model}
        //{ performancePoints}
        //PP - ${ moneyWon}
        //o    3. { brand}
        //{ model}
        //{ performancePoints}
        //PP - ${ moneyWon}”



    }
}

