
public abstract class Feline : Mammal
{
    private string breed;
    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public Feline(string name, double weigth, string livingRegion, string breed)
        : base(name, weigth, livingRegion)
    {
        this.Breed = breed;
    }

    public override string ToString()
    {
        return $"{this.GetType()} [{this.Name}, {this.breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

