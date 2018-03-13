public class Track
    {
    private int lapsNumber;

    public int LapsNumber
    {
        get { return lapsNumber; }
         set { lapsNumber = value; }
    }
    private int currLapsNumber;

    public int CurrLapsNumber
    {
        get { return currLapsNumber; }
        set { currLapsNumber = value; }
    }


    private int length;

    public int Length
    {
        get { return length; }
        set { length = value; }
    }

        public Track(int lapsNumber, int length)
        {
            this.LapsNumber = lapsNumber;
            this.Length = length;
         
        }
    private int currLaps;

    public int CurrLaps
    {
        get { return currLaps; }
        set { currLaps = value; }
    }

}

