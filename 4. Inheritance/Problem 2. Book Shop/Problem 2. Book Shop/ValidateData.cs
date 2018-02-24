using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ValidateData
{
    protected void ValidateAuthor(string name)
    {
        if (name.Split(' ').Length == 2)
        {
            var lastName = name.Split(' ').ToList()[1];
            var firstChar = lastName[0];
            if (int.TryParse(firstChar.ToString(), out int num))
            {
                throw new ArgumentException("Author not valid!");
            }
        }
    }

    protected void ValidateTitle(string title)
    {
        if (title.Length < 3)
            throw new ArgumentException("Title not valid!");
    }

    protected void ValidatePrice(decimal price)
    {
        if (price <= 0)
            throw new ArgumentException("Price not valid!");
    }
}
