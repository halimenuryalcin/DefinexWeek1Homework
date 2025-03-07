using System;

namespace WindowsFormsApp1
{
    public interface IPaymentMethod
    {
        public string payTheAmount(string name, string amount);
       
    }
}