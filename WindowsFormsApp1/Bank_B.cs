namespace WindowsFormsApp1
{
    public class Bank_B:IPaymentMethod
    {
        public string payTheAmount(string name, string amount)
        {
            return $"Payment successful By Bank_B\n: {name} {amount} TL";

        }
    }
}