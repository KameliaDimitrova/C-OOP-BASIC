using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string carModel;
    private Engine carEngine;
    private double carWeigth;
    private string carColor;

    public string CarModel
    {
        get => this.carModel;
        set => this.carModel = value;

    }
    public Engine CarEngine
    {
        get => this.carEngine;
        set => this.carEngine = value;

    }
    public double CarWeigth
    {
        get => this.carWeigth;
        set => this.carWeigth = value;

    }
    public string CarColor
    {
        get => this.carColor;
        set => this.carColor = value;
    }

    public Car(string model, Engine engine)
    {
        this.carModel = model;
        this.carEngine = engine;
        this.carWeigth = -1;
        this.carColor = "n/a";
    }
    public Car(string model, Engine engine, double weight, string color):this(model,engine)
    {
        this.carModel = model;
        this.carEngine = engine;
        this.carWeigth = weight;
        this.carColor = color;
    }
    public Car(string model, Engine engine, double weight) : this(model, engine)
    {
        this.carModel = model;
        this.carEngine = engine;
        this.carWeigth = weight;
    }
    public Car(string model, Engine engine, string color) : this(model, engine)
    {
        this.carModel = model;
        this.carEngine = engine;
        this.carColor = color;
    }

    public Car()
    {
    }

 
}

