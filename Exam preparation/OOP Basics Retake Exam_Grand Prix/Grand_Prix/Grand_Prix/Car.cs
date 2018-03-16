
using System;

public class Car
{
    private int hp;

    public int Hp
    {
        get { return hp; }
       private set { hp = value; }
    }

    private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
         set
        {
            if (value < 0)
            {
              
                throw new ArgumentException("Out of fuel");
            }
            if (value > 160)
            {
                fuelAmount = 160;
            }
            else
            fuelAmount = value;
        }
    }
    private Tyre tyre;

    public Tyre Tyre
    {
        get { return tyre; }
        set { tyre = value; }
    }

 

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
      
    }

}

