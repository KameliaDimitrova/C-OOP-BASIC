using System;
using System.Collections.Generic;
using System.Text;


public class Stats
{
    private decimal edurance;

    public decimal Edurance
    {
        get { return edurance; }
        private set
        {
            new ValidateStats(value, "Endurance");
            edurance = value;
        }
    }

    private decimal sprint;

    public decimal Sprint
    {
        get { return sprint; }
        private set
        {
            new ValidateStats(value, "Sprint");
            sprint = value;
        }
    }

    private decimal dribble;

    public decimal Dribble
    {
        get { return dribble; }
        private set
        {
            new ValidateStats(value, "Dribble");
            dribble = value;
        }
    }

    private decimal passing;

    public decimal Passing
    {
        get { return passing; }
        private set
        {
            new ValidateStats(value, "Passing");
            passing = value;
        }
    }

    private decimal shooting;

    public decimal Shooting
    {
        get { return shooting; }
        private set
        {
            new ValidateStats(value, "Shooting");
            shooting = value;
        }
    }

    public Stats()
    {
    }

    public Stats(decimal edurance, decimal sprint, decimal dribble, decimal passing, decimal shooting)
    {
        this.Edurance = edurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    public decimal CalculatePlayerStats()
    {
        return (decimal)(this.edurance + this.sprint + this.dribble + this.passing + this.shooting) / 5;
    }


}

