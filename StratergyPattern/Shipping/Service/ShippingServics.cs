public class ShippingService
{
    public readonly ShippingStatergy _shippingStatergy;

    public ShippingService(ShippingStatergy shippingStatergy)
    {
        _shippingStatergy = shippingStatergy;
    }

    public void CalculateShippingCost(decimal weight)
    {
        _shippingStatergy.CalculateShippingCost(weight);
    }
}