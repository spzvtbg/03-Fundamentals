using System;
using System.Collections.Generic;
using System.Linq;

public class Shop
{
    private ICollection<Person> persons;
    private ICollection<Product> products;

    public Shop(string[] persons, string[] products)
    {
        this.persons = new List<Person>();
        this.products = new List<Product>();

        this.CreateListOfPersons(persons);
        this.CreateListOfProducts(products);
    }

    public ICollection<Person> Persons => this.persons;

    public ICollection<Product> Products => this.products;

    private void CreateListOfProducts(string[] products)
    {
        foreach (var product in products)
        {
            var data = product.SplitBy("=");

            var name = data[0];
            var cost = decimal.Parse(data[1]);

            try
            {
                this.products.Add(new Product(name, cost));
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException(ae.Message);
            }
        }
    }

    private void CreateListOfPersons(string[] persons)
    {
        foreach (var person in persons)
        {
            var data = person.SplitBy("=");

            var name = data[0];
            var money = decimal.Parse(data[1]);

            try
            {
                this.persons.Add(new Person(name, money));
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException(ae.Message);
            }
        }
    }

    public void ShowData()
    {
        foreach (var person in this.persons)
        {
            if (person.Bag.Count == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
                continue;
            }

            Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(x => x.Name))}");
        }
    }

}
