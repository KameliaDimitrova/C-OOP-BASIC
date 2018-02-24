using System;
using System.Collections.Generic;
using System.Text;


public class Worker:Human
{
    private decimal weekSalary;

    public decimal WeekSalary
    {
        get { return weekSalary; }
        private set
        {
            ValidateWeekSalary(value);
            weekSalary = value;
        }
    }

    private decimal weekHoursPerDay;

    public decimal WeekHoursPerDay
    {
        get { return weekHoursPerDay; }
        private set
        {
            ValidateWorkingHours(value);
            weekHoursPerDay = value;
        }
    }

    public Worker(string firstName, string secondName, decimal weekSalary, decimal weekHoursPerDay) : base(firstName,
        secondName)
    {
        this.WeekSalary = weekSalary;
        this.WeekHoursPerDay = weekHoursPerDay;
    }

    public Worker()
    {
    }

    private decimal SalaryPerHour()
    {
        var salaryPerHour = this.weekSalary / (this.weekHoursPerDay * 5);
        return salaryPerHour;
    }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}" +
               $"Week Salary: {this.weekSalary:f2}{Environment.NewLine}" +
               $"Hours per day: {this.weekHoursPerDay:f2}{Environment.NewLine}" +
               $"Salary per hour: {SalaryPerHour():f2}{Environment.NewLine}";
    }
}

