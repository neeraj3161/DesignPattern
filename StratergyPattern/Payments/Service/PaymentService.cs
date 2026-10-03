public class PaymentService
{
    private readonly IPaymentStratergy _paymentStratergy;

    public PaymentService(IPaymentStratergy paymentStratergy)
    {
        _paymentStratergy = paymentStratergy;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentStratergy.Pay(amount);
    }
}