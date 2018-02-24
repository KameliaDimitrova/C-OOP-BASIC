using System;
using System.Collections.Generic;
using System.Text;


public class Student : Human
{
    private string facilityNumber;

    public string FacilityNumber
    {
        get { return facilityNumber; }
        private set
        {
            ValidateFacilityNumber(value);
            facilityNumber = value;
        }
    }

    public Student()
    {
    }

    public Student(string firstName, string secondName, string facilityNumber) : base(firstName, secondName)
    {
        this.FacilityNumber = facilityNumber;
    }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}" +
               $"Faculty number: {this.facilityNumber}{Environment.NewLine}";
    }
}

