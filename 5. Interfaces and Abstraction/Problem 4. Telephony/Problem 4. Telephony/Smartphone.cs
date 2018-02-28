
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Smartphone:ICall,IBrowse
{
    private List<string> phoneNumbersToCall;

    public List<string> PhoneNumbersToCall
    {
        get { return phoneNumbersToCall; }
        set { phoneNumbersToCall = value; }
    }

    private List<string> siteToBrowseList;

    public List<string> SiteToBrowseList
    {
        get { return siteToBrowseList; }
        set { siteToBrowseList = value; }
    }

    public Smartphone(List<string> phoneNumbersToCall, List<string> siteToBrowseList)
    {
        this.PhoneNumbersToCall = phoneNumbersToCall;
        this.SiteToBrowseList = siteToBrowseList;
    }

    public string GetCalling()
    {
        var result = string.Empty;
        foreach (var phoneNumber in phoneNumbersToCall)
        {
            if (!phoneNumber.All(char.IsDigit))
            {
                result = result + InvalidInput("number");
            }
            else
            result = result + $"Calling... {phoneNumber}{Environment.NewLine}";
        }
        return result;
    }

    public string Browsing()
    {
        var result = string.Empty;
        foreach (var site in siteToBrowseList)
        {
            if (site.Any(char.IsDigit))
            {
                result = result + InvalidInput("URL");
            }
            else
            result = result + $"Browsing: {site}!{Environment.NewLine}";
        }
        return result;
    }

    private string InvalidInput(string input)
    {
        return $"Invalid {input}!{Environment.NewLine}";
    }
    public override string ToString()
    {
        return $"{GetCalling()}{Browsing()}";
    }
}

