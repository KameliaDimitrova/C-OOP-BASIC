
using System;
using System.Collections.Specialized;

public abstract class Tyre
{
    private string name;

    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }
    private double hardness;

    public double Hardness
    {
        get { return hardness; }
     }

    private double degradation;

    public double Degradation
    {
        get { return degradation; }
        set
        {
            if (value < 0 && this.Name == "Hard")
            {
                throw new ArgumentException("Blown Tyre");
            }
            if (value < 30 && this.Name == "Ultrasoft")
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }

    protected Tyre(double hardness)
    {
        this.hardness = hardness;
        this.Degradation = 100;
    }

    public virtual void DegradateTyre(int laps)
    {
        
    }
}

