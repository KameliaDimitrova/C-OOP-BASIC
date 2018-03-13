public class HardTyre:Tyre
    {
      public HardTyre(double hardness)
        :base(hardness)
        {
            this.Name = "Hard";
        }

        public override void DegradateTyre(int laps)
        {
            for (int i = 1; i <= laps; i++)
            {
                this.Degradation = this.Degradation - this.Hardness;
            }
        }
    }
