public class ApplePayPayment: IPaymentStratergy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Apple Pay.");
    }
}