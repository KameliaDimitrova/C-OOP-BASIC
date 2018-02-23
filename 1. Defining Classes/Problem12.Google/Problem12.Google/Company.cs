using System;
using System.Collections.Generic;
using System.Text;

public class Company
{
    private string compName;
    private string compDepartment;
    private decimal compSalary;

    public Company()
    {
    }

    public Company(string name, string department, decimal salary)
    {
        this.compName = name;
        this.compDepartment = department;
        this.compSalary = salary;
    }

    public string CompDepartment
    {
        get => this.compDepartment;
        set => this.compDepartment = value;
    }
    public decimal CompSalary
    {
        get => this.compSalary;
        set => this.compSalary = value;
    }
    public string CompName
    {
        get => this.compName;
        set => this.compName = value;
    }

    public void LastAdedCompani(string name, string department, decimal salary)
    {
        this.compName = name;
        this.compDepartment = department;
        this.compSalary = salary;
    }

    public string CompanyResult(Perosn person)
    {
        if (person.Company.compName != null)
        {
            return $"{Environment.NewLine}{this.compName} {this.compDepartment} {this.compSalary}";
        }
        return "";
    }
}