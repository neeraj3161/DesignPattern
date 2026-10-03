public class UpiPayment: IPaymentStratergy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using UPI.");
    }
}