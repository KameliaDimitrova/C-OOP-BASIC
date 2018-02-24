using System;
using System.Collections.Generic;
using System.Text;


public class GoldenEditionBook:Book
{
    private decimal price;

    public override decimal Price
    {
        get { return base.Price; }
        protected set
        {
            base.Price = value+value*0.3M;
        }
    }

    public GoldenEditionBook()
    {
    }

    public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
    {

    }
}
