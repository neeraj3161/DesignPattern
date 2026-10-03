public class Express: ShippingStatergy
{
    public void CalculateShippingCost(decimal weight)
    {
        decimal cost = weight * 1.5m; 
        Console.WriteLine($"Express Shipping Cost: {cost}");
    }
}