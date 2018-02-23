using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Department
{
    private List<Employee> employees;
    private string departmentName;

    public List<Employee> Employees
    {
        get => this.employees;
    }

    public string DepartmentName
    {
        get => this.departmentName;
        set => this.departmentName = value;
    }

    public Department(string name)
    {
        this.employees = new List<Employee>();
        this.DepartmentName = name;
    }

    public decimal AverageSalary => this.Employees.Select(x => x.Salary).Average();

    public void AddEmployee(Employee employee)
    {
       this.Employees.Add(employee);
    }
   
}

