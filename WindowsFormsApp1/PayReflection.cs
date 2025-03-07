using System.Reflection;

namespace WindowsFormsApp1
{
    public class PayReflection
    {
        public IPaymentMethod GetInstance(string classname)
        {
            var newObject = Assembly.GetAssembly(typeof(IPaymentMethod)).CreateInstance("WindowsFormsApp1." + classname);
            return (IPaymentMethod)newObject;
        }
    }
}