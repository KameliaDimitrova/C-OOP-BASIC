using System;
using System.Collections.Generic;
using System.Text;


public class Parents
{
    private string paarentName;
    private string parentBirthday;

    public Parents(string name, string birthday)
    {
        this.paarentName = name;
        this.parentBirthday = birthday;
    }

    public string ParentName
    {
        get => this.paarentName;
        set => this.paarentName = value;
    }

    public string ParentBirthday
    {
        get => this.parentBirthday;
        set => this.parentBirthday = value;
    }
}
    