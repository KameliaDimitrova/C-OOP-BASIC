using System;
using System.Collections.Generic;
using System.Text;

public class Tires
{
    private double tirePresure;
    private int tireAge;

    public double TirePresure
    {
        get => this.tirePresure;
        set => this.tirePresure = value;
    }

    public int TireAge
    {
        get => this.tireAge;
        set => this.tireAge = value;
    }

    public Tires(double tirePresure,int tireAge)
    {
        this.tirePresure = tirePresure;
        this.tireAge = tireAge;
    }
}

