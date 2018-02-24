using System;
using System.Collections.Generic;
using System.Text;


public class Book:ValidateData
{
    private string title;

    public string Title
    {
        get { return title; }
        protected set
        {
            ValidateTitle(value);
            title = value;
        }
    }

    private string author;

    public string Author
    {
        get { return author; }
        protected set
        {
            ValidateAuthor(value);
            author = value;
        }
    }

    private decimal price;

    public virtual decimal Price
    {
        get { return price; }
        protected set
        {
            ValidatePrice(value);
            price = value;
        }
    }

    public Book()
    {
    }

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name}{Environment.NewLine}" +
               $"Title: {this.title}{Environment.NewLine}" +
               $"Author: {this.author}{Environment.NewLine}" +
               $"Price: {this.Price:f2}";
    }
}

