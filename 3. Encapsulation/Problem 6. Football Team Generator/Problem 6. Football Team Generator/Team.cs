using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Enumerable = System.Linq.Enumerable;


public class Team
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

    private List<Player> players;

    public List<Player> Players
    {
        get { return players; }
        private set { players = value; }
    }


    public Team()
    {
    }

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    public string CalculateTeamRating()
    {
            var teamRatingResult = 0M;
            foreach (var player in players)
            {
                teamRatingResult = teamRatingResult + player.CalculatePlayerSkillLevel();
            }

            return $"{this.name} - {teamRatingResult:f0}";
    }

    public void AddPlayer(Player player)
    {
           players.Add(player);
    }

    public void RemovePlayer(string playerName)
    {
        if (this.Players.All(x => x.Name != playerName))
        {
            throw new ArgumentException($"Player {playerName} is not in {name} team.");
        }
        players.RemoveAll(x => x.Name == playerName);
    }
}

