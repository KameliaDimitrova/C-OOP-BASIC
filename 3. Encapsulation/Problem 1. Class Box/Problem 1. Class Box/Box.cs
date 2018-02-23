using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

public class Box
{
    private decimal length;

    public decimal Length
    {
        get { return length; }
        private set { length = value; }
    }

    private decimal width;

    public decimal Width
    {
        get { return width; }
        private set { width = value; }
    }

    private decimal height;

    public decimal Height
    {
        get { return height; }
        private set { height = value; }
    }

    public Box(decimal length, decimal width, decimal height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }


    public decimal BoxSurfaceArea()
    {
        var boxSurgfaceAreaResult =
            2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
        return boxSurgfaceAreaResult;
    }


    public decimal BoxLateralSurfaceArea()
    {
        var boxLateralSurfaceAreaResult =
            2 * this.length * this.height + 2 * this.width * this.height;
        return boxLateralSurfaceAreaResult;
    }

    public decimal BoxVolume()
    {
        var boxVolumeResult = this.length * this.width * this.height;
        return boxVolumeResult;
    }


    public override string ToString()
    {
        return $"Surface Area - {BoxSurfaceArea():f2}{Environment.NewLine}" +
               $"Lateral Surface Area - {BoxLateralSurfaceArea():f2}{Environment.NewLine}" +
               $"Volume - {BoxVolume():f2}";
    }
}

