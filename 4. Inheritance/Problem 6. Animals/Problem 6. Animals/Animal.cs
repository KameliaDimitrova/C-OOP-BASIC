using System;
using System.Collections.Generic;
using System.Text;


public class Animal:ISoundProducable
{

    private const string ERORR_MESSAGE = "Invalid input!";
    private string name;

    public string Name
    {
        get { return name; }
       private set
        {
            NotEmptyValidation(value);
            name = value;
        }
    }

    private int age;

    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(ERORR_MESSAGE);
            }
            age = value;
        }
    }

    private string gender;

    public string Gender
    {
        get { return gender; }
        private set
        {
            NotEmptyValidation(value);
            gender = value;
        }
    }

    public Animal()
    {
    }

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    private static void NotEmptyValidation(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(ERORR_MESSAGE);
        }
    }

    public virtual string ProduceSound()
    {
        return "NOISE!!!!!!!!";
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}{Environment.NewLine}" +
               $"{this.name} {this.age} {this.gender}{Environment.NewLine}" +
               $"{this.ProduceSound()}{Environment.NewLine}";
    }
}

