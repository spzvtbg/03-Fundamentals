namespace ConsoleApp1
{
    using Logger.Contracts;
    using Logger.Factories;
    using System;

    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            var command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var errors = command.Split('|');
                var level = errors[0];
                var date = errors[1];
                var message = errors[2];
                var error = errorFactory.CreateError(date, level, message);
                this.logger.Log(error);
            }

            Console.WriteLine("Logger info:");

            foreach (var appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
