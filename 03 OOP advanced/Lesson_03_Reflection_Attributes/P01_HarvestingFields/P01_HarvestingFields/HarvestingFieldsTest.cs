namespace P01_HarvestingFields
{
    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var commandHolder = new CommandHolder(typeof(HarvestingFields));
            var commandInterpreter = new CommandInterpreter(commandHolder);
            commandInterpreter.StartExecuting();
        }
    }
}
