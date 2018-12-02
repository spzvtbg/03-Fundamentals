using System;
using System.Linq;
using System.Reflection;

namespace P02_BlackBoxInteger
{
    public class ComandInterpreter
    {
        private BlackBoxInteger blackBoxInteger;
        private MethodInfo[] methods;
        private string commandData;

        public ComandInterpreter(BlackBoxInteger blackBoxInteger)
        {
            this.blackBoxInteger = blackBoxInteger;
            this.methods = blackBoxInteger.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public void StartReadingCommands()
        {
            while ((commandData = Console.ReadLine()) != "END")
            {
                var commandArgs = commandData
                    .Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

                var command = commandArgs[0];
                var parameter = Int32.Parse(commandArgs[1]);

                var method = this.methods.FirstOrDefault(x => x.Name == command);
                var result = method.Invoke(this.blackBoxInteger, new object[] { parameter });

                Console.WriteLine(
                    this
                    .blackBoxInteger
                    .GetType()
                    .GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(this.blackBoxInteger)
                    .ToString());
            }
        }
    }
}