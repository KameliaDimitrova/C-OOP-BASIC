
using System;

public class Private : Soldier
{
    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Private(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public override string ToString()
    {
       return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.salary:f2}";
    }
}

