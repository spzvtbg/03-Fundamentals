using System;
using System.Linq;

public class SpecialisedSoldier : Soldier
{
    private string corps;
    private string[] corpsAllowed = { "airforces", "marines" };

    protected SpecialisedSoldier(params string[] parameters) : base(parameters)
    {
        this.Corps = parameters[4];
    }

    public string Corps
    {
        get
        {
            return this.corps;
        }
        set
        {
            if (this.corpsAllowed.Contains(value.ToLower()))
            {
                this.corps = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}{Environment.NewLine}Corps: {this.Corps}{Environment.NewLine}";
    }
}
