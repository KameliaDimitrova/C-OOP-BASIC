using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6.Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            List<Department> departments=new List<Department>();
        
            for (int i = 0; i < number; i++)
            {
                Employee newEmployee = new Employee();
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                if (input.Length == 4)
                {
                  newEmployee=new Employee(name,salary,position,department);
                }
               else  if (input.Length == 6)
                {
                    var email = input[4];
                    var age = int.Parse(input[5]);
                     newEmployee=new Employee(name,salary,position,department,email,age);
                }
                else if (input.Length == 5)
                {

                    if (int.TryParse(input[4], out var age))
                    {
                        newEmployee = new Employee(name, salary, position, department, age);
                    }
                    else
                    {
                        var email = input[4];
                        newEmployee = new Employee(name, salary, position, department, email);
                    }
                }
                if (!departments.Any(x => x.DepartmentName == department))
                {
                    Department currDepartment=new Department(department);
                    departments.Add(currDepartment);
                }
                departments.First(x=>x.DepartmentName==department).AddEmployee(newEmployee);

               
            }
            var departmentWithHighestAvarage = departments.OrderByDescending(x => x.AverageSalary).First();
            Console.WriteLine($"Highest Average Salary: {departmentWithHighestAvarage.DepartmentName}");
            foreach (var emp in departmentWithHighestAvarage.Employees.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }
        }
    }
}