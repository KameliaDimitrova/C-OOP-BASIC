
public abstract class Mammal : Animal
{
    private string livingRegion;

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public Mammal(string name, double weight, string livingRegion)
        : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }


    public override string ToString()
    {
        return $"{this.GetType()} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

