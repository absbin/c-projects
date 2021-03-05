using System;
namespace AccessModifier
{
    public class AMClass3 : AMClass1
    {
        public AMClass3()
        {
            Console.WriteLine("********************");
        }
        public void accessTest3()
        {
            // Console.WriteLine("In AMClass1 privateVar is : " + privateVar); // Private var is not accessible
            Console.WriteLine("In AMClass3 protectedVar is : " + protectedVar); // Proteced var is accessible by inheritance
        }

    }
}