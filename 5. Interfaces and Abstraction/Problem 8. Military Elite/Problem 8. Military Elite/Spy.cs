using System;

public class Spy : Soldier
{
    private int codeNumberOfSpy;

    public int CodeNumberOfSpy
    {
        get { return codeNumberOfSpy; }
        set { codeNumberOfSpy = value; }
    }

    public Spy(int id, string firstName, string lastName,int codeNumberOfSpy)
        : base(id, firstName, lastName)
    {
        this.CodeNumberOfSpy = codeNumberOfSpy;
    }

    public override string ToString()
    {
        return $"{base.ToString()}" +
               $"{Environment.NewLine}Code Number: {this.codeNumberOfSpy}";
    }
}

