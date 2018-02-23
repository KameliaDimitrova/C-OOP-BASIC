using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player
{
    private string name;

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    private Stats stats;

    public Stats Stats
    {
        get { return stats; }
        private set { stats = value; }
    }

    public Player()
    {

    }

    public Player(string name, Stats stats)
    {
        this.Name = name;
        this.Stats = stats;
    }

    public decimal CalculatePlayerSkillLevel()
    {
        return this.stats.CalculatePlayerStats();
    }



}

