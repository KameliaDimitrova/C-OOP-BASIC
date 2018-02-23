using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DataModifier
{
    private int day;
    private int month;
    private int year;

    public int Day
    {
        get => this.day;
        set => this.day = value;
    }
    public int Month
    {
        get => this.month;
        set => this.month = value;
    }

    public int Year
    {
        get => this.year;
        set => this.year = value;
    }

    public int CalculatesTheDifferenceBetweeenTwoDate(string firstDate, string SecondDate)
    {
        var data1 = firstDate
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        this.day = data1[0];
        this.month = data1[1];
        this.year = data1[2];
        DateTime firsDateTime=new DateTime(day,month,year);

        var data2 = SecondDate
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        this.day = data2[0];
        this.month = data2[1];
        this.year = data2[2];
        DateTime secondDateTime = new DateTime(day, month, year);
        if (secondDateTime > firsDateTime)
        {
            return secondDateTime.Subtract(firsDateTime).Days;
        }
        else
        {
            return firsDateTime.Subtract(secondDateTime).Days;
        }
    }
}
