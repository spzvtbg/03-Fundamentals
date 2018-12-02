namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter
    {
        private string command;
        private CommandHolder commandHolder;
        private MethodInfo[] commandMethods;

        public CommandInterpreter(CommandHolder commandHolder)
        {
            this.commandHolder = commandHolder;
            this.commandMethods = commandHolder.GetType().GetMethods();
        }

        public void StartExecuting()
        {
            while ((this.command = Console.ReadLine()) != "HARVEST")
            {
                var output = (object[])this.commandMethods
                    .FirstOrDefault(x => x.Name.ToLower()
                    .Contains(this.command.ToLower()))
                    .Invoke(this.commandHolder, new object[] { });

                OutputManager.Print((string[])output[0], (ConsoleColor)output[1]);
            }
        }
    }
}
