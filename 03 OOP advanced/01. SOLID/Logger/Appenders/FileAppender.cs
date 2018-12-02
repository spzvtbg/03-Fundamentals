namespace Logger.Appenders
{
    using Contracts;
    using Logger.Enums;

    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout)
        { }

        public ILayout Layout => throw new System.NotImplementedException();

        public ErrorLevel ErrorLevel => throw new System.NotImplementedException();

        public void Append(IError error)
        {
            throw new System.NotImplementedException();
        }
    }
}
