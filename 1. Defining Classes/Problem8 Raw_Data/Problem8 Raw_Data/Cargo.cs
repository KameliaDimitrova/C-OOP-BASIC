using System;
using System.Collections.Generic;
using System.Text;


public class Cargo
{
    private int cargoWeigth;
    private string cargoType;
    public int CargoWeigth { get => this.cargoWeigth; set => this.cargoWeigth = value; }
    public string CargoType { get => this.cargoType; set => this.cargoType = value; }

    public Cargo(int cargoWeigth,string cargoType)

    {
        this.cargoWeigth = cargoWeigth;
        this.cargoType = cargoType;
    }
}

