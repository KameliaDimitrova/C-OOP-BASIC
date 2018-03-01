
using System;
using System.Collections.Generic;

public class Engineer:SpecialisedSoldier
{
    private Dictionary<string,int> repairs;

    public Dictionary<string,int> Repairs
    {
        get { return repairs; }
        set { repairs = value; }
    }

    public Engineer(int id, string firstName, string lastName, double salary,string corps,Dictionary<string,int> repairs)
        : base(id, firstName, lastName, salary,corps)
    {
        this.Repairs = repairs;
    }
    public override string ToString()
    {
        var listOfRepairs = string.Empty;
        foreach (var rep in repairs)
        {
            listOfRepairs = listOfRepairs + $"{Environment.NewLine}  Part Name: {rep.Key} Hours Worked: {rep.Value}";
        }
        return $"{base.ToString()}{Environment.NewLine}" +
               $"Corps: {this.Corps}{Environment.NewLine}" +
               $"Repairs:" +
               $"{listOfRepairs}";
    }
}
