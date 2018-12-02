using System;
using System.Text;

public class Book
{
    private string author;

    private string titel;

    private decimal price;

    public Book(string author, string titel, decimal price)
    {
        this.Author = author;
        this.Titel = titel;
        this.Price = price;
    }

    public string Author
    {
        get
        {
            return this.author;
        }

        set
        {
            var names = value.Split(new[] { " " }, StringSplitOptions.None);

            if (names.Length >= 2)
            {
                var secondName = names[1];

                if (char.IsDigit(secondName[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            this.author = value;
        }
    }

    public string Titel
    {
        get
        {
            return this.titel;
        }

        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.titel = value;
        }
    }

    public virtual decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Type: {this.GetType().Name}");
        stringBuilder.AppendLine($"Title: {this.Titel}");
        stringBuilder.AppendLine($"Author: {this.Author}");
        stringBuilder.AppendLine($"Price: {this.Price:F2}");

        return stringBuilder.ToString().TrimEnd();
    }
}
