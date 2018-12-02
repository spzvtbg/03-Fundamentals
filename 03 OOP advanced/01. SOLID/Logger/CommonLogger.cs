namespace Logger
{
    using Contracts;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class CommonLogger : ILogger
    {
        private readonly ICollection<IAppender> appenders;

        public CommonLogger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public ICollection<IAppender> Appenders => new List<IAppender>(this.appenders);

        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                if ((int)appender.ErrorLevel <= (int)error.ErrorLevel)
                {
                    appender.Append(error);
                }
            }
        }
    }
}
