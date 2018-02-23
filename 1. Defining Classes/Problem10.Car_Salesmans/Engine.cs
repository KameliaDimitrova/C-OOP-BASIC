using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    private string engineModel;
    private double enginePower;
    private double engineDisplacement;
    private string engineEfficiency;

    public string EngineModel
    {
        get => this.engineModel;
        set => this.engineModel = value;
    }
    public double EnginePower
    {
        get => this.enginePower;
        set => this.enginePower = value;
    }
    public double EngineDisplacement
    {
        get => this.engineDisplacement;
        set => this.engineDisplacement = value;
    }
    public string EngineEfficiency
    {
        get => this.engineEfficiency;
        set => this.engineEfficiency = value;
    }

    public Engine(string model, double power)
    {
        this.engineModel = model;
        this.enginePower = power;
        this.engineDisplacement =  -1;
        this.engineEfficiency = "n/a";
    }
    public Engine(string model, double power, double displacement, string efficiency):this(model,power)
    {
       
        this.engineDisplacement = displacement;
        this.engineEfficiency = efficiency;
    }
    public Engine(string model, double power, double displacement) : this(model, power)
    {
        this.engineDisplacement = displacement;
    }
    public Engine(string model, double power, string efficiency) : this(model, power)
    {
        this.engineEfficiency = efficiency;
    }

    public Engine()
    {
    }

}

