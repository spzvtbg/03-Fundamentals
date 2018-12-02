namespace ConsoleApp1
{
    using Logger;
    using Logger.Contracts;
    using Logger.Factories;

    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static LayoutFactory layoutFactory = new LayoutFactory();
        private static AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);
        private static ICollection<IAppender> appenders = new List<IAppender>();

        public static void Main()
        {
            var logger = InitializeLogger();
            var engine = new Engine(logger, new ErrorFactory());
            engine.Run();
        }

        public static ILogger InitializeLogger()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var args = Console.ReadLine().Split();
                var appenderType = args[0];
                var layoutType = args[1];
                var errorType = "INFO";

                if (args.Length > 2)
                {
                    errorType = args[2];
                }

                var appender = appenderFactory.CreateAppender(appenderType, errorType, layoutType);
                appenders.Add(appender);
            }

            return new CommonLogger(appenders);
        }
    }
}
