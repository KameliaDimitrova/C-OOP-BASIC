using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    private decimal money;

    public decimal Money
    {
        get { return money; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Money cannot be negative");
            money = value;
        }
    }

    private List<Product> products;

    public List<Product> Products
    {
        get { return products; }
        private set { products = value; }
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.products = new List<Product>();
    }

    public string WantedToBuySomethig(Product product)
    {
        if (this.money >= product.Cost)
        {
            this.money = this.money - product.Cost;
            this.products.Add(product);
            return $"{this.name} bought {product.Name}";
        }
        else
            return $"{this.name} can't afford {product.Name}";
    }

    public override string ToString()
    {
        if (this.products.Count == 0)
            return $"{name} - Nothing bought";
        return $"{name} - {string.Join(", ", products)}";
    }
}


