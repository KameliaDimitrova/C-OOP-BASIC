using System;
using System.Collections.Generic;
using System.Text;
using Problem1.Define_Interface_IPerson;


    public class Citizen:IPerson
    {
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

}

