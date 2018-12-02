using System;
using System.Linq;
using System.Reflection;

public static class FarmFactory
{
    public static Animal CreateAnimal(params string[] parameters)
    {
        var type = parameters[0].ToLower();
        var name = parameters[1];
        var weight = double.Parse(parameters[2]);

        var assembly = Assembly.GetExecutingAssembly();
        var classes = assembly.GetTypes();
        var typeOfAnimal = classes.FirstOrDefault(t => t.Name.ToLower() == type);

        if (type == "hen" || type == "owl")
        {
            var wingSize = double.Parse(parameters[3]);
            return (Bird)Activator.CreateInstance(typeOfAnimal, name, weight, wingSize);
        }
        else if (type == "mouse" || type == "dog")
        {
            var livingRegion = parameters[3];
            return (Mamal)Activator.CreateInstance(typeOfAnimal, name, weight, livingRegion);
        }

        var livingRegionFelines = parameters[3];
        var breed = parameters[4];
        return (Feline)Activator.CreateInstance(typeOfAnimal, name, weight, livingRegionFelines, breed);
    }

    public static Food CreateFood(params string[] parameters)
    {
        var type = parameters[0].ToLower();
        var value = int.Parse(parameters[1]);

        var assembly = Assembly.GetExecutingAssembly();
        var classes = assembly.GetTypes();
        var typeOfFood = classes.FirstOrDefault(t => t.Name.ToLower() == type);

        return (Food)Activator.CreateInstance(typeOfFood, value);
    }
}
