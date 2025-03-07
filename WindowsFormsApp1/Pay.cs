namespace WindowsFormsApp1
{
    public class Pay
    {
        public IPaymentMethod PaymentMethod;

        public Pay(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void payTheCost(string name, string amount)
        {
            PaymentMethod.payTheAmount(name,amount);
            
        }
    }
}