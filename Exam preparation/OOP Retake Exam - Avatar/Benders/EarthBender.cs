public   class EarthBender:Bender
    {
        private double groundSaturation;

    public double GroundSaturation
    {
            get { return groundSaturation; }
            private set { groundSaturation = value; }
        }

        public EarthBender(string name, int power, double groundSaturation)
            : base(name, power)
        {
            this.GroundSaturation = groundSaturation;
        }

        public override string ToString()
        {
            return $"Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroundSaturation:f2}";
        }

        public override double GetBenderPower()
        {
            return this.Power * this.GroundSaturation;
        }
}
