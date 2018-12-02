public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string titel, string author, decimal price) : base(titel, author, price)
    {
    }

    public override decimal Price
    {
        get
        {
            return base.Price * 1.3m;
        }
    }
}
