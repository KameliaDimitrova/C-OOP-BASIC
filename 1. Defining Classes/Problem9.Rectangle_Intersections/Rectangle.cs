using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double topLeftX;
    private double topLeftY;

    public string Id
    {
        get => this.id;
        set => this.id = value;
    }
    public double Width
    {
        get => this.width;
        set => this.width = value;
    }
    public double Height
    {
        get => this.height;
        set => this.height = value;
    }
    public double TopLeftX
    {
        get => this.topLeftX;
        set => this.topLeftX = value;
    }
    public double TopLeftY
    {
        get => this.topLeftY;
        set => this.topLeftY = value;
    }

    public Rectangle()
    {
    }

    public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
    }

    public bool IsTwoRectangleInsect(Rectangle secondRectangle)
    {
        if (this.topLeftX + this.width < secondRectangle.topLeftX ||
            secondRectangle.topLeftX + secondRectangle.width <this.topLeftX ||
            this.topLeftY + this.height <secondRectangle.topLeftY ||
            secondRectangle.topLeftY + secondRectangle.height <this.topLeftY)
        {
            return false;
        }
        return true;
    }
}

