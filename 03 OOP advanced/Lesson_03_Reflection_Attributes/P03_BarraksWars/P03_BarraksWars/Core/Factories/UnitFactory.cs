namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var type = types.FirstOrDefault(x => x.Name == unitType);
            var instance = (IUnit)Activator.CreateInstance(type);

            return instance;
        }
    }
}
