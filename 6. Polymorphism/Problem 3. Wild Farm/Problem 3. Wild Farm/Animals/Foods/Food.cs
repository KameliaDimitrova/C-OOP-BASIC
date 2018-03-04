
public abstract class Food
{
    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public Food(int quantity)
    {
        this.Quantity = quantity;
    }

    public Food()
    {
        
    }
}

