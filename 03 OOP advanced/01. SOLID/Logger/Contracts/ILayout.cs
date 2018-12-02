namespace Logger.Contracts
{
    public interface ILayout
    {
        string Format(IError error);
    }
}
