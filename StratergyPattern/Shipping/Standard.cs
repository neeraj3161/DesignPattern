public class Standard: ShippingStatergy
{
    public void CalculateShippingCost(decimal weight)
    {
        decimal cost = weight * 1.0m; 
        Console.WriteLine($"Standard Shipping Cost: {cost}");
    }
}