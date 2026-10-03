public class International: ShippingStatergy
{
    public void CalculateShippingCost(decimal weight)
    {
        decimal cost = weight * 2.0m; 
        Console.WriteLine($"International Shipping Cost: {cost}");
    }
}