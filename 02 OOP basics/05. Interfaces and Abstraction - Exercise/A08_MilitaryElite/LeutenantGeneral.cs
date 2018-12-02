using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LeutenantGeneral : Soldier
{
    private IEnumerable<string> privateIds;

    public LeutenantGeneral(params string[] parameters) : base(parameters)
    {
        this.Privates = new List<Soldier>();
        this.privateIds = parameters.Skip(4);
    }

    public ICollection<Soldier> Privates { get; private set; }

    public void SetPrivates(ICollection<Soldier> privates)
    {
        foreach (var id in privateIds)
        {
            var privateSoldier = privates.FirstOrDefault(x => x.Id == id);

            if (privateSoldier != null)
            {
                this.Privates.Add(privateSoldier);
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString());
        sb.AppendLine($"{Environment.NewLine}Privates:");

        foreach (var privateSoldier in this.Privates)
        {
            sb.AppendLine($"  {privateSoldier.ToString()}");
        }

        return sb.ToString().Trim();
    }
}
