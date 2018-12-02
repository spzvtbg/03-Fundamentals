namespace Logger.Factories
{
    using Contracts;
    using Enums;
    using Appenders;

    using System;

    public class AppenderFactory
    {
        const string DEFAULT_FILE = "logFile{0}.txt";
        private int fileAppenders = 0;
        private LayoutFactory layouts;

        public AppenderFactory(LayoutFactory layouts)
        {
            this.layouts = layouts;
        }

        public IAppender CreateAppender(string appenderType, string errorString, string layoutType)
        {
            var layout = this.layouts.CreateLayout(layoutType);
            var errorLevel = default(ErrorLevel);
            var success = Enum.TryParse(errorString, true, out errorLevel);

            if (!success)
            {
                throw new ArgumentException("Invalid error level type!");
            }

            if (appenderType == nameof(ConsoleAppender))
            {
                return new ConsoleAppender(layout, errorLevel);
            }
            else if (appenderType == nameof(FileLogger))
            {
                return new FileLogger(string.Format(DEFAULT_FILE, ++fileAppenders));
            }
            else
            {
                throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
