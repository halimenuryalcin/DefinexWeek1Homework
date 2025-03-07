namespace WindowsFormsApp1
{
    public class Bank_A:IPaymentMethod
    {
        public string payTheAmount(string name, string amount)
        {
            string result = name+" "+" kişiye ait "+amount+" TL ödeme A bankası ile yapılmıştır.";
            return $"Payment successful By Bank_A\n: {name} {amount} TL";
        }
    }
}