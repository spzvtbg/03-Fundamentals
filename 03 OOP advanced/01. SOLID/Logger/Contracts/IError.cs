namespace Logger.Contracts
{
    using Enums;

    using System;

    public interface IError
    {
        DateTime Time { get; }

        string Message { get; }

        ErrorLevel ErrorLevel { get; }
    }
}