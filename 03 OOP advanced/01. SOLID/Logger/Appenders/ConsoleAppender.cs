namespace Logger.Appenders
{
    using Contracts;
    using Enums;

    using System;
    using System.Text;

    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel errorLevel)
        {
            this.Layout = layout;
            this.ErrorLevel = errorLevel;
        }

        public ILayout Layout { get; }

        public ErrorLevel ErrorLevel { get; }

        public int MessagesCount { get; private set; }

        public void Append(IError error)
        {
            this.MessagesCount++;
            Console.WriteLine(this.Layout.Format(error));
        }

        public override string ToString()
        {
            var result = 
                "Appender type: {0}, Layout type: {1}, Report level: {2}, Messages appended: {3}";

            return string
                .Format(result
                , this.GetType().Name
                , this.Layout.GetType().Name
                , this.ErrorLevel
                , this.MessagesCount);
        }
    }
}
