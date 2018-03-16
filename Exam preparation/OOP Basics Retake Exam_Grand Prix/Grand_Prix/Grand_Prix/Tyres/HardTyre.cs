public class HardTyre : Tyre
{
    public HardTyre(double hardness)
    : base(hardness)
    {
        this.Name = "Hard";
    }

    public override void DegradateTyres()
    {
        this.Degradation = this.Degradation - this.Hardness;
    }
}

