using System;
using System.Linq;

public abstract class Phone : ICallable, IBrowseble
{
    public Phone(string[] numbers, string[] urls)
    {
        this.ParseNumbers(numbers);
        this.ParseUrls(urls);
    }

    private void ParseNumbers(string[] numbers)
    {
        var length = numbers.Length;
        this.Numbers = new string[length];

        for (int index = 0; index < length; index++)
        {
            if (numbers[index].Any(x => !char.IsDigit(x)))
            {
                this.Numbers[index] = "Invalid number!";
            }
            else
            {
                this.Numbers[index] = $"Calling... {numbers[index]}";
            }
        }
    }

    private void ParseUrls(string[] urls)
    {
        var length = urls.Length;
        this.Urls = new string[length];

        for (int index = 0; index < length; index++)
        {
            if (urls[index].Any(x => char.IsDigit(x)))
            {
                this.Urls[index] = "Invalid URL!";
            }
            else
            {
                this.Urls[index] = $"Browsing: {urls[index]}!";
            }
        }
    }

    public string[] Numbers { get; private set; }

    public string[] Urls { get; private set; }

    public void Show()
    {
        foreach (var item in this.Numbers)
        {
            Console.WriteLine(item);
        }

        foreach (var item in this.Urls)
        {
            Console.WriteLine(item);
        }
    }
}
