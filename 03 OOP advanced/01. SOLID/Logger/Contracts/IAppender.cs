﻿namespace Logger.Contracts
{
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        ErrorLevel ErrorLevel { get; }

        void Append(IError error);
    }
}
