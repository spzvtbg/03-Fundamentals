using System;
using System.Linq;
using System.Reflection;

public static class SoldierFactory
{
    public static Soldier Get(params string[] parameters)
    {
        var type = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(x => x.Name.ToLower() == parameters[0].ToLower());
        
        return (Soldier)Activator.CreateInstance(type, parameters.Skip(1).ToArray());
    }
}
