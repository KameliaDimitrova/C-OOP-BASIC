using System;
using System.Collections.Generic;
using System.Text;


class Ferrari:ICar
{
    private string driverName;

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }


    private string model;
    public string Model
    {
        get { return model; }
        set { model = "488-Spider"; }
    }

    public Ferrari(string driverName)
    {
        this.Model = model;
        this.DriverName = driverName;
    }

    public override string ToString()
    {
        return $"{this.model}/{PushBreaks()}/{PushGas()}/{this.driverName}";
    }
}

