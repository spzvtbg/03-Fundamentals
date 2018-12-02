using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class VehicleFactory
{
    private Dictionary<string, Dictionary<string, Action<double>>> functions;

    public VehicleFactory()
    {
        this.functions = new Dictionary<string, Dictionary<string, Action<double>>>();
    }

    public static Vehicle GetNew(params string[] parameters)
    {
        var type = parameters[0];
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        var typeOfSerchedObject = types.FirstOrDefault(x => x.Name.ToLower() == type);
        
        return (Vehicle)Activator.CreateInstance(typeOfSerchedObject, parameters);
    }

    public void AddFunction(string action, string objekt, Action<double> function)
    {
        if (!this.functions.ContainsKey(action))
        {
            this.functions[action] = new Dictionary<string, Action<double>>();
        }
        if (!this.functions[action].ContainsKey(objekt))
        {
            this.functions[action][objekt] = function;
        }
    }

    public void Execute(params string[] parameters)
    {
        var action = parameters[0];
        var objekt = parameters[1];
        var value = double.Parse(parameters[2]);

        this.functions[action][objekt].Invoke(value);
    }
}
