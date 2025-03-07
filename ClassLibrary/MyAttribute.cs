using System;

namespace ClassLibrary
{
    public class MyAttribute
    {

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
        public class MyCustomAttribute : Attribute
        {
            public string Description { get; }
           

            public MyCustomAttribute(string description)
            {
                Description = description;
                
            }
        }
    }
}