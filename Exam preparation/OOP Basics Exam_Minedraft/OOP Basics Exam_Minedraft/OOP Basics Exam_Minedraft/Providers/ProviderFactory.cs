using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public Provider Get(List<string> arguments)
    {
        var providerType = arguments[0];
        switch (providerType)
        {
            case "Solar":
              return new SolarProvider(arguments[1], double.Parse(arguments[2]));
            case "Pressure":
               return new PressureProvider(arguments[1], double.Parse(arguments[2]));
            default: throw new ArgumentException("Factory Error!");
        }
    }
}

