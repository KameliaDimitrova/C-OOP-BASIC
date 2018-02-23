using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;


public class ValidateStats
{
    public ValidateStats(decimal currStats,string stat)
    {
        if (currStats < 0 || currStats > 100)
        {
            throw new ArgumentException($"{stat} should be between 0 and 100.");
        }
    }

    
}

