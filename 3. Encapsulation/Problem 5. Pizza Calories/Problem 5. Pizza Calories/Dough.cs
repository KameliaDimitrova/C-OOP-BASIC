using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;


public class Dough
{
    private const string WHITE = "white";
    private const string WHOLEGRAIN = "wholegrain";
    private const decimal WHITE_MODIFIER = (decimal)1.5;
    private const decimal WHOLEGRAIN_MODIFIER = (decimal)1.0;
    private const string CRISPY = "crispy";
    private const string CHEWY = "chewy";
    private const string HOMEMADE = "homemade";
    private const decimal CRISPY_MODIFIER = (decimal)0.9;
    private const decimal CHEWY_MODIFIER = (decimal)1.1;
    private const decimal HOMEMADE_MODIFIER = (decimal)1.0;

    private decimal weigth;

    public decimal Weigth
    {
        get { return weigth; }
        private set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200]");
            }
            weigth = value;
        }
    }

    private string flourType;

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (value.ToLower() != WHITE && value.ToLower() != WHOLEGRAIN)
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    private string bakingTechnique;

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (value.ToLower() != CRISPY && value.ToLower() != CHEWY && value.ToLower() != HOMEMADE)
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public Dough()
    {
    }

    public Dough(string flourType, string bakingTechnique, decimal weigth)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weigth = weigth;
    }

    public decimal CalculateDoughCaloriews()
    {
        var flourModifier = (decimal)0;
        var techniqueModifier = (decimal)0;
        switch (this.flourType.ToLower())
        {
            case WHITE:
                flourModifier= WHITE_MODIFIER;
                break;
            case WHOLEGRAIN:
               flourModifier = WHOLEGRAIN_MODIFIER;
                break;
        }
        switch (this.bakingTechnique.ToLower())
        {
            case CRISPY:
                techniqueModifier = CRISPY_MODIFIER;
                break;
            case CHEWY:
                techniqueModifier = CHEWY_MODIFIER;
                break;
            case HOMEMADE:
                techniqueModifier = HOMEMADE_MODIFIER;
                break;
        }


        return (2 * this.weigth) * flourModifier * techniqueModifier;
    }
}
