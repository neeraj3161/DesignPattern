public class MilkCoffee : ICoffee
{
    private readonly ICoffee _coffee;

    public MilkCoffee(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public void makeCoffee()
    {
        _coffee.makeCoffee();
        //This is the additional functionality added by the decorator below
        Console.WriteLine("Adding milk to the coffee.");
    }
}