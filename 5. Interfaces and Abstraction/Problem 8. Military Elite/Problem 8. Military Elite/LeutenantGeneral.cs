
using System;
using System.Collections.Generic;

public class LeutenantGeneral:Private
{
    private List<Private> privates;

    public List<Private> Privates       
    {
        get { return privates; }
        set { privates = value; }
    }

    public LeutenantGeneral(int id, string firstName, string lastName,double salary,List<Private> privates)
        : base(id, firstName, lastName,salary)
    {
        this.Privates = privates;
    }

    public override string ToString()
    {
        var listOfprivateResult = string.Empty;
        foreach (var privat in privates)
        {
            listOfprivateResult = $"{listOfprivateResult}{Environment.NewLine}  {privat}";
        }
        return $"{base.ToString()}{Environment.NewLine}" +
               $"Privates: {listOfprivateResult}";
    }
}

