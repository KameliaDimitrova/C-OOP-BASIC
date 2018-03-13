
 using System;
 using System.Collections.Generic;

public  class Car
{
   private int hp;

   private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
        set
        {
            if (value > 160)
            {
                fuelAmount = 160;
            }
            else if (value < 0)
            {
                throw new ArgumentException("Out of fuel");
            }
            else
            fuelAmount = value;
        }
    }

    private Tyre tyre;

    public Tyre Tyre
    {
        get { return tyre; }
        private set { tyre = value; }
    }


    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public void AddFuel(string fuelAmount)
    {
        this.FuelAmount = this.fuelAmount;
    }

    public double GetCarSpeed()
    {
        var carSpeed= (this.hp + this.Tyre.Degradation)/ this.FuelAmount;
        return carSpeed;
    }

    public void ChangeTyres(List<string> args)
    {
        if (args.Count == 5)
        {
            this.tyre=new HardTyre(double.Parse(args[4]));
        }
        else
        {
            this.tyre=new UltrasoftTyre(double.Parse(args[4]),double.Parse(args[5]));
        }
    }
}
