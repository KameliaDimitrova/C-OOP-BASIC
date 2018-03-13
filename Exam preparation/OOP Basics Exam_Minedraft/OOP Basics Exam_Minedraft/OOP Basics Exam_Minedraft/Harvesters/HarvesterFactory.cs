using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester Get(List<string> arguments)
    {
        var harvesterType = arguments[0];
        switch (harvesterType)
        {
            case "Sonic":
                return new SonicHarvester(arguments[1], double.Parse(arguments[2]),double.Parse(arguments[3]), int.Parse(arguments[4]));
            case "Hammer":
                return new HammerHarvester(arguments[1], double.Parse(arguments[2]),double.Parse(arguments[3]));
            default: throw new ArgumentException("Factory Error!");
        }
    }
}

