namespace P02_BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var interpreter = new ComandInterpreter(
                (BlackBoxInteger)Activator.CreateInstance(typeof(BlackBoxInteger), true));
            interpreter.StartReadingCommands();
        }
    }
}
