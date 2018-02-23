using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string carModel;
    private int carSpeed;

    public Car()
    {
    }

    public string CarModel
    {
        get => this.carModel;
        set => this.carModel = value;
    }
    public int CarSpeed
    {
        get => this.carSpeed;
        set => this.carSpeed = value;
    }

    public Car(string model, int speed)
    {
        this.carModel = model;
        this.carSpeed = speed;
    }

    public void LastAdedCar(string model, int speed)
    {
        this.carModel = model;
        this.carSpeed = speed;
    }
    public string CarResult(Perosn person)
    {
        if (person.Car.carModel != null)
        {
            return $"{Environment.NewLine}{person.Car.carModel} {person.Car.carSpeed}";
        }
        return "";
       
    }
}


