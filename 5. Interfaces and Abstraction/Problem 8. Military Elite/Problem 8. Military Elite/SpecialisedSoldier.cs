
using System.Collections.Generic;

public class SpecialisedSoldier:Private
{
    private string corps;

    public string Corps
    {
        get { return corps; }
        set { corps = value; }
    }
    public SpecialisedSoldier(int id, string firstName, string lastName, double salary,string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

}
