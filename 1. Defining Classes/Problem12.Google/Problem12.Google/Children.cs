using System;
using System.Collections.Generic;
using System.Text;

public class Children
{
    private string childrenName;
    private string childrenBirthday;

    public Children(string name, string birthday)
    {
        this.childrenName = name;
        this.childrenBirthday = birthday;
    }

    public string ChildrenName
    {
        get => this.childrenName;
        set => this.childrenName = value;
    }

    public string ChildrenBirthday
    {
        get => this.childrenBirthday;
        set => this.childrenBirthday = value;
    }
}
