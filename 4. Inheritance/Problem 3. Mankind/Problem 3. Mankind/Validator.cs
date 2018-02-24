using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Validator
{
    protected const int FIRST_NAME_MIN_LENGTH = 4;
    protected const int SECOND_NAME_MIN_LENGTH = 3;

    protected void ValidateName(string name,int nameMinLength,string whichName)
    {
        if (!char.IsUpper(name[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {whichName}");
        }
        if (name.Length < nameMinLength)
        {
            throw new ArgumentException($"Expected length at least {nameMinLength} symbols! Argument: {whichName}");
        }
    }

    protected void ValidateFacilityNumber(string facilityNumber)
    {
        if (facilityNumber.Length < 5 || facilityNumber.Length > 10 || !facilityNumber.All(char.IsLetterOrDigit))
        {
            throw new ArgumentException("Invalid faculty number!");
        }
    }

    protected void ValidateWeekSalary(decimal salary)
    {
        if (salary <=10)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
        }
    }

    protected void ValidateWorkingHours(decimal weekHours)
    {
        if (weekHours < 1 || weekHours > 12)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
        }
    }
}

