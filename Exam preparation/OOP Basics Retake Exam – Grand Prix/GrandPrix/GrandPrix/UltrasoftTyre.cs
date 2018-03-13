
public class UltrasoftTyre : Tyre
{
    private double grip;

    public double Grip
    {
        get { return grip; }
       }

    public UltrasoftTyre(double hardness,double grip)
        :base(hardness)
    {
        this.Name = "Ultrasoft";
        this.grip = grip;
    }

    public override void DegradateTyre(int laps)
    {
        for (int i = 1; i <= laps; i++)
        {
            this.Degradation = this.Degradation - (this.Hardness+this.Grip);
        }
    }
}


