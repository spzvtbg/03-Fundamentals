namespace Logger.Errors
{
    using Contracts;
    using Enums;

    using System;

    public class Error : IError
    {
        public Error(DateTime time, string message)
        {
            this.Time = time;
            this.Message = message;
            this.ErrorLevel = ErrorLevel.INFO;
        }

        public Error(DateTime time, ErrorLevel errorLevel, string message)
        {
            this.Time = time;
            this.Message = message;
            this.ErrorLevel = errorLevel;
        }

        public DateTime Time { get; }

        public string Message { get; }

        public ErrorLevel ErrorLevel { get; }
    }
}
