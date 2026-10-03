public class AddSugar: ICoffee
{
    private readonly ICoffee _coffee;

    public AddSugar(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public void makeCoffee()
    {
        _coffee.makeCoffee();
        //This is the additional functionality added by the decorator below
        Console.WriteLine("Adding sugar to the coffee.");
    }
}