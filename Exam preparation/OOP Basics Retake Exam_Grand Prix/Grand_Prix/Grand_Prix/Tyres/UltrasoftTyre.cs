using System;

public class UltrasoftTyre:Tyre
{
    private double grip;

    public double Grip  
    {
        get { return grip; }
        private set
        {
        
            grip = value;
        }
    }

    public UltrasoftTyre(double hardness, double grip)
        : base(hardness)
    {
        this.Name= "Ultrasoft";
        this.Grip = grip;
    }

    public override void DegradateTyres()
    {
        this.Degradation = this.Degradation - (this.Hardness+this.Grip);
    }
}
