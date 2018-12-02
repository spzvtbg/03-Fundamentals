using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;
        var soldiers = new List<Soldier>();
        var privates = new List<Soldier>();

        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            var parameters = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var soldier = SoldierFactory.Get(parameters);

                if (soldier.GetType().Name == "Private")
                {
                    privates.Add(soldier);
                }

                if (soldier.GetType().Name == "LeutenantGeneral")
                {
                    var leutenantGeneral = soldier as LeutenantGeneral;
                    leutenantGeneral.SetPrivates(privates);
                    soldier = leutenantGeneral;
                }

                soldiers.Add(soldier);
            }
            catch
            {
                continue;
            }
        }

        soldiers.ForEach(x => Console.WriteLine(x.ToString()));
    }
}
