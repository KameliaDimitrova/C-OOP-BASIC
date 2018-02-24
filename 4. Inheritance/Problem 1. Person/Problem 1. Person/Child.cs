using System;
using System.Collections.Generic;
using System.Text;


public class Child:Person
{
    private string name;

    public string Name
    {
        get { return base.Name; }
        protected set { base.Name = value; }
    }

    private int age;

    public override int Age
    {
        get { return base.Age; }
        protected set
        {
            if (value > 15)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
            base.Age = value;
        }
    }

    public Child(string name, int age):base(name,age)
    {
        
    }

}

