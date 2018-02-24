using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

public class Human:Validator
{
    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        protected set
        {
            ValidateName(value,FIRST_NAME_MIN_LENGTH,"firstName");
            firstName = value;
        }
    }

    private string secondName;

    public string SecondName
    {
        get { return secondName; }
        protected set
        {
            ValidateName(value,SECOND_NAME_MIN_LENGTH,"lastName");
            secondName = value;
        }
    }

    public Human()
    {
    }

    public Human(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }

    public override string ToString()
    {
        return $"First Name: {this.firstName}{Environment.NewLine}" +
               $"Last Name: {this.secondName}";
    }
}

